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
        private string exe_path = "";

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

        /// <summary>
        /// 文件列表
        /// </summary>
        private List<CopyFileModel> copyFileList = new List<CopyFileModel>();

        /// <summary>
        /// 当前的复制文件
        /// </summary>
        private CopyFileModel currentCopyFile = null;

        /// <summary>
        /// 当前路径
        /// </summary>
        private string currentPath = string.Empty;

        /// <summary>
        /// 目标路径
        /// </summary>
        private string targetPath = string.Empty;

        // <summary>
        /// 绑定数据源
        /// </summary>
        private BindingSource bindingSourceDGV1 = new BindingSource();

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

                currentPath = fldDlg.SelectedPath;

                copyFileList.Clear();

                // 获取currentPath目录下的所有文件
                string[] fileList = Directory.GetFiles(currentPath);
                for (int i = 0; i < fileList.Length; i++)
                {
                    CopyFileModel copyFileModel = new CopyFileModel();
                    copyFileModel.listID = i + 1;
                    copyFileModel.SrcFile = fileList[i];
                    copyFileModel.SrcLastTime = File.GetLastWriteTime(copyFileModel.SrcFile).ToString();
                    copyFileModel.SrcFileSize = new FileInfo(copyFileModel.SrcFile).Length;
                    this.copyFileList.Add(copyFileModel);
                }

                this.bindingSourceDGV1.ResetBindings(false);
            }
            else
            {
                this.txtBoxRootPath.Text = string.Empty;
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
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                currentCopyFile.SrcFile = openDlg.FileName;
                currentCopyFile.SrcLastTime = File.GetLastWriteTime(currentCopyFile.SrcFile).ToString();
                currentCopyFile.SrcFileSize = new FileInfo(currentCopyFile.SrcFile).Length;

                this.bindingSourceDGV1.ResetBindings(false);
            }
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

            // 获取文件名
            saveDlg.FileName = Path.GetFileName(currentCopyFile.SrcFile);

            this.txtBoxTargetFile.Text = string.Empty;

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                this.txtBoxTargetFile.Text = saveDlg.FileName;
                currentCopyFile.TargetFile = saveDlg.FileName;
                if (File.Exists(currentCopyFile.TargetFile))
                {
                    currentCopyFile.TLastTime = File.GetLastWriteTime(currentCopyFile.TargetFile).ToString();
                    currentCopyFile.TFileSize = new FileInfo(currentCopyFile.TargetFile).Length;
                }

                this.bindingSourceDGV1.ResetBindings(false);
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

            //if (File.Exists(this.txtBoxSrcFile.Text.Trim()) == false)
            //{
            //    MessageBox.Show("[当前文件]不存在!!!");
            //    return;
            //}

            //if (File.Exists(this.txtBoxTargetFile.Text.Trim()) == false)
            //{
            //    MessageBox.Show("[目标文件]不存在!!!");
            //    return;
            //}

            CopyFileModel copyFileModel = new CopyFileModel();
            copyFileModel.listID = this.dataGridView1.Rows.Count + 1;
            copyFileModel.SrcFile = this.txtBoxSrcFile.Text.Trim();

            if (File.Exists(copyFileModel.SrcFile))
            {
                copyFileModel.SrcLastTime = File.GetLastWriteTime(copyFileModel.SrcFile).ToString();
                copyFileModel.SrcFileSize = new FileInfo(copyFileModel.SrcFile).Length;
            }
            copyFileModel.TargetFile = this.txtBoxTargetFile.Text.Trim();
            if (File.Exists(copyFileModel.TargetFile))
            {
                copyFileModel.TLastTime = File.GetLastWriteTime(copyFileModel.TargetFile).ToString();
                copyFileModel.TFileSize = new FileInfo(copyFileModel.TargetFile).Length;
            }

            this.copyFileList.Add(copyFileModel);
            this.bindingSourceDGV1.ResetBindings(false);
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

            this.copyFileList.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            this.bindingSourceDGV1.ResetBindings(false);
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

            currentCopyFile.SrcFile = this.txtBoxSrcFile.Text.Trim();
            if (File.Exists(currentCopyFile.SrcFile))
            {
                currentCopyFile.SrcLastTime = File.GetLastWriteTime(currentCopyFile.SrcFile).ToString();
                currentCopyFile.SrcFileSize = new FileInfo(currentCopyFile.SrcFile).Length;
            }

            currentCopyFile.TargetFile = this.txtBoxTargetFile.Text.Trim();
            if (File.Exists(currentCopyFile.TargetFile))
            {
                currentCopyFile.TLastTime = File.GetLastWriteTime(currentCopyFile.TargetFile).ToString();
                currentCopyFile.TFileSize = new FileInfo(currentCopyFile.TargetFile).Length;
            }

            this.bindingSourceDGV1.ResetBindings(false);
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

        /// <summary>
        /// 选择行变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                currentCopyFile = (CopyFileModel)this.dataGridView1.SelectedRows[0].DataBoundItem;

                this.txtBoxSrcFile.Text = currentCopyFile.SrcFile;
                this.txtBoxTargetFile.Text = currentCopyFile.TargetFile;
            }
        }

        private void MainFrm_Shown(object sender, EventArgs e)
        {
            copyFileList.Add(new CopyFileModel()
            {
                listID = 1,
                SrcFile = "C:\\1.bin",
                SrcLastTime = "2018-01-01 00:00:00",
                SrcFileSize = 1024,
                TargetFile = "C:\\2.bin",
                TLastTime = "2018-01-01 00:00:00",
                TFileSize = 1024
            }
                );
            bindingSourceDGV1.DataSource = this.copyFileList;
            this.dataGridView1.DataSource = bindingSourceDGV1;
            bindingSourceDGV1.ResetBindings(false);
        }

        /// <summary>
        /// 刷新 文件信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (File.Exists(currentCopyFile.SrcFile))
            {
                currentCopyFile.SrcFileSize = new FileInfo(currentCopyFile.SrcFile).Length;
                currentCopyFile.SrcLastTime = new FileInfo(currentCopyFile.SrcFile).LastWriteTime.ToString();
            }
            else
            {
                currentCopyFile.SrcFileSize = 0;
                currentCopyFile.SrcLastTime = string.Empty;

            }

            if (File.Exists(currentCopyFile.TargetFile))
            {
                currentCopyFile.TFileSize = new FileInfo(currentCopyFile.TargetFile).Length;
                currentCopyFile.TLastTime = new FileInfo(currentCopyFile.TargetFile).LastWriteTime.ToString();
            }
            else
            {
                currentCopyFile.TFileSize = 0;
                currentCopyFile.TLastTime = string.Empty;
            }

            this.bindingSourceDGV1.ResetBindings(false);
        }

        private void btnTargetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldDlg = new FolderBrowserDialog();

            if (fldDlg.ShowDialog() == DialogResult.OK)
            {
                this.txtBoxTargetPath.Text = fldDlg.SelectedPath;
                targetPath = fldDlg.SelectedPath;

                foreach (var item in this.copyFileList)
                {
                    if (string.IsNullOrEmpty(item.TargetFile))
                    {
                        item.TargetFile = Path.Combine(targetPath, Path.GetFileName(item.SrcFile));
                    }
                }

                this.bindingSourceDGV1.ResetBindings(false);
            }
            else
            {
                this.txtBoxTargetPath.Text = string.Empty;
            }
        }
    }
}