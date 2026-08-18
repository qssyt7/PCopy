using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace PCopy
{
    public partial class MainFrm : Form
    {

        string exe_path = "";

        private string xml_string =
    "<?xml version=\"1.0\" encoding=\"utf-8\"?> " +
    "<bincombine>" +
        "<fromfile>" +
            "<filename>c:\\from\\1.bin</filename>" +
            "<offset>0x00000000</offset>" +
            "<fillvalue>1</fillvalue>" +
            "<fillsize>1</fillsize>" +
        "</fromfile>" +
    "</bincombine> ";

        public MainFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择根目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRootPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldDlg = new FolderBrowserDialog();

            if (fldDlg.ShowDialog() == DialogResult.OK)
            {
                this.txtBoxRootPath.Text = fldDlg.SelectedPath;

                this.groupBox1.Enabled = true;
            }
            else
            {
                this.txtBoxRootPath.Text = string.Empty;
                this.groupBox1.Enabled = false;
            }
        }

        /// <summary>
        /// 选择源文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSrcFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();

            this.txtBoxSrcFile.Text = openDlg.FileName;
            this.txtBoxTargetFile.Text = Path.GetFileName(openDlg.FileName);
           
            
        }

        /// <summary>
        /// 选择复制到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopyTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.RestoreDirectory = true;
            saveDlg.InitialDirectory = this.txtBoxRootPath.Text;
            saveDlg.FileName = this.txtBoxTargetFile.Text;

            this.txtBoxTargetFile.Text = string.Empty;

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {

                if (this.txtBoxTargetFile.Text.Trim().Length > 0)
                {

                    this.txtBoxTargetFile.Text = saveDlg.FileName;

                }
                else
                {
                    if (saveDlg.FileName.IndexOf(this.txtBoxRootPath.Text.Trim()) >= 0)
                    {

                        this.txtBoxTargetFile.Text =  Path.GetFileName(saveDlg.FileName);
                    }
                    else
                    {
                        MessageBox.Show("选择的目录，不是根目录的子目录。");

                        this.txtBoxTargetFile.Text = Path.GetFileName(saveDlg.FileName);
                    }
                }
            }
        }

        /// <summary>
        /// 增加对应关系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (this.txtBoxSrcFile.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请指定[源文件]路径!!!");
                return;
            }

            if (this.txtBoxSrcFile.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请指定[复制到]路径!!!");
                return;
            }

            int no = 1;

            this.dataGridView1.Rows.Add();

            this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[1].Value
                 = this.txtBoxSrcFile.Text.Trim();

            this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[2].Value
                = this.txtBoxTargetFile.Text.Trim();

            foreach (DataGridViewRow tmpRow in this.dataGridView1.Rows)
            {
                tmpRow.Cells[0].Value = no.ToString();
                no ++;
            }
        }

        /// <summary>
        /// 删除对应关系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请先选择要删除的行!!!");

                return;
            }
        }

        /// <summary>
        /// 修改对应关系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请先选择要修改的行!!!");

                return;
            }
        }

        /// <summary>
        /// 开始复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileCopy_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("请先编辑复制文件的对应列表!!!");
                
                return;
            }
        }

        /// <summary>
        /// 保存列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveXml_Click(object sender, EventArgs e)
        {


            if (this.dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("请先添加文件", "提示");
                return;
            }

            string xml_path = Path.Combine(exe_path, "default.xml");

            //SaveFileDialog saveDlg = new SaveFileDialog();
            //saveDlg.Filter = "XML文件|*.xml|所有文件|*.*";
            //saveDlg.p
            //saveDlg.FileName = "default.xml";
            //saveDlg.ShowDialog();

            try
            {

                XmlDocument xml = new XmlDocument();

                if (File.Exists(xml_path))
                {
                    xml.Load(xml_path);
                }
                else
                {

                    xml.LoadXml(this.xml_string);
                }

                XmlElement xmlRoot = xml.DocumentElement;
                xmlRoot.RemoveAll();

                foreach (DataGridViewRow tmpRow in this.dataGridView1.Rows)
                {
                    XmlElement copyFile = xml.CreateElement("copyfile");

                    XmlElement filename = xml.CreateElement("filename");

                    filename.InnerText = Path.GetFileName(Convert.ToString(tmpRow.Cells[0].Value));

                    XmlElement offset = xml.CreateElement("offset");
                    offset.InnerText = Convert.ToString(tmpRow.Cells[1].Value);

                    XmlElement fillvalue = xml.CreateElement("fillvalue");
                    fillvalue.InnerText = Convert.ToString(tmpRow.Cells[2].Value);

                    XmlElement fillsize = xml.CreateElement("fillsize");
                    fillsize.InnerText = Convert.ToString(tmpRow.Cells[3].Value);

                    copyFile.AppendChild(filename);
                    copyFile.AppendChild(offset);
                    copyFile.AppendChild(fillvalue);
                    copyFile.AppendChild(fillsize);

                    xmlRoot.AppendChild(copyFile);
                }

                xml.Save(xml_path);

                MessageBox.Show("文件列表保存成功", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "异常");
            }

        }


        /// <summary>
        /// 读取列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadXml_Click(object sender, EventArgs e)
        {
            string xml_path = Path.Combine(exe_path, "default.xml");

            try
            {
                this.dataGridView1.Rows.Clear();

                XmlDocument xml = new XmlDocument();

                if (File.Exists(xml_path))
                {
                    xml.Load(xml_path);
                }
                else
                {
                    MessageBox.Show("请先保存文件列表", "提示");
                    return;
                }


                XmlElement xmlRoot = xml.DocumentElement;

                foreach (XmlNode node in xmlRoot.ChildNodes)
                {
                    this.dataGridView1.Rows.Add();

                    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[0].Value = Path.Combine(exe_path, node["filename"].InnerText);
                    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[1].Value = node["offset"].InnerText;
                    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[2].Value = node["fillvalue"].InnerText;
                    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[3].Value = node["fillsize"].InnerText;

                }

                // this.txtBoxDestFile.Text = Path.Combine(exe_path, string.Format("bin_release_{0}.bin", DateTime.Now.ToString("yyyyMMddHHmmss")));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "异常");

            }

        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Load(object sender, EventArgs e)
        {
            exe_path = Application.StartupPath;
        }

        /// <summary>
        /// 源文件->目标文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnST_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 目标文件->源文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTS_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 源文件->所有目标文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnALLST_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 所有目标文件->源文件
        /// </summary>
        private void btnALLTS_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 比较 当前文件与目标文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompare_Click(object sender, EventArgs e)
        {

        }
    }
}
