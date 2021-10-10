using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace PCopy
{
    public partial class MainFrm : Form
    {
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
            ;

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

        }


        /// <summary>
        /// 读取列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadXml_Click(object sender, EventArgs e)
        {

        }

    }
}
