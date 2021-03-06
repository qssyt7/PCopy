﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Xml;

namespace bincombine
{
    public partial class MainFrm : Form
    {
        long file_size = 0;
        
        uint fillvalue = 0;

        string exe_path = "";

        private Thread combineThr;

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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBoxbincombine aboutFrm = new AboutBoxbincombine();
            aboutFrm.ShowDialog();
        }

        private void txtBoxOffset_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = "0123456789ABCDEF\b".IndexOf(char.ToUpper(e.KeyChar)) < 0;
        }

        private void btnTargtFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = string.Format("bin_release_{0}.bin" ,DateTime.Now.ToString("yyyyMMddHHmmss") );
            dialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            dialog.CheckFileExists = false;
            dialog.ShowDialog();
            this.txtBoxDestFile.Text = dialog.FileName;

        }

        private void btnSelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            dialog.ShowDialog();
            this.txtboxFromFile.Text = dialog.FileName;
            if (dialog.FileName.Length > 0)
            {
                FileInfo info = new FileInfo(dialog.FileName);
                this.file_size = info.Length;
                this.lblFileSize.Text = string.Format("文件大小：{0}B", this.file_size);
            }

        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (this.txtboxFromFile.Text.Length <= 0)
            {
                MessageBox.Show("请选择要合并的文件！！！");
            }
            else
            {
                string str = this.txtBoxOffset.Text.Trim().PadLeft(8, '0');
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[1].Value).Trim() == str)
                    {
                        if (MessageBox.Show(string.Format("偏移量为{0}的文件已经存在，是否进行替换？", str), "是否替换", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                        {
                            row.Cells[0].Value = this.txtboxFromFile.Text;
                            row.Cells[1].Value = str;
                            row.Cells[2].Value = this.rdoBtnFill1.Checked ? "1" : "0";
                            row.Cells[3].Value = this.file_size;
                        }
                        return;
                    }
                }
                uint num = Convert.ToUInt32(str, 0x10);
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToUInt32(this.dataGridView1.Rows[i].Cells[1].Value.ToString(), 0x10) > num)
                    {
                        if ((i > 0) && ((Convert.ToUInt32(this.dataGridView1.Rows[i - 1].Cells[1].Value.ToString(), 0x10) + Convert.ToUInt32(this.dataGridView1.Rows[i - 1].Cells[3].Value)) >= num))
                        {
                            MessageBox.Show("新加文件的偏移量值冲突！！！\r\n当前偏移量不可以小于等于前个文件的偏移量加上文件小大。\r\n偏移量>前个文件的偏移量 + 文件大小", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else if ((num + this.file_size) >= Convert.ToUInt32(this.dataGridView1.Rows[i].Cells[1].Value.ToString(), 0x10))
                        {
                            MessageBox.Show("新加文件的偏移量值冲突！！！\r\n当前偏移量加上文件小大不能大于等于后一个文件的偏移量。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            this.dataGridView1.Rows.Insert(i, 1);
                            this.dataGridView1.Rows[i].Cells[0].Value = this.txtboxFromFile.Text;
                            this.dataGridView1.Rows[i].Cells[1].Value = str;
                            this.dataGridView1.Rows[i].Cells[2].Value = this.rdoBtnFill1.Checked ? "1" : "0";
                            this.dataGridView1.Rows[i].Cells[3].Value = this.file_size;
                        }
                        return;
                    }
                }
                if ((this.dataGridView1.Rows.Count > 0) && ((Convert.ToUInt32(this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[1].Value.ToString(), 0x10) + Convert.ToUInt32(this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[3].Value)) >= num))
                {
                    MessageBox.Show("新加文件的偏移量值冲突！！！\r\n当前偏移量不可以小于等于前个文件的偏移量加上文件小大。\r\n偏移量>前个文件的偏移量 + 文件大小", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    int num3 = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[num3].Cells[0].Value = this.txtboxFromFile.Text;
                    this.dataGridView1.Rows[num3].Cells[1].Value = str;
                    this.dataGridView1.Rows[num3].Cells[2].Value = this.rdoBtnFill1.Checked ? "1" : "0";
                    this.dataGridView1.Rows[num3].Cells[3].Value = this.file_size;
                }
            }

        }

        private void btnDelFile_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                this.dataGridView1.Rows.Remove(this.dataGridView1.SelectedRows[0]);
            }

        }

        private void btnSaveList_Click(object sender, EventArgs e)
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
                    XmlElement fromFile = xml.CreateElement("fromfile");

                    XmlElement filename = xml.CreateElement("filename");

                    filename.InnerText = Path.GetFileName(Convert.ToString(tmpRow.Cells[0].Value));

                    XmlElement offset = xml.CreateElement("offset");
                    offset.InnerText = Convert.ToString(tmpRow.Cells[1].Value);

                    XmlElement fillvalue = xml.CreateElement("fillvalue");
                    fillvalue.InnerText = Convert.ToString(tmpRow.Cells[2].Value);

                    XmlElement fillsize = xml.CreateElement("fillsize");
                    fillsize.InnerText = Convert.ToString(tmpRow.Cells[3].Value);

                    fromFile.AppendChild(filename);
                    fromFile.AppendChild(offset);
                    fromFile.AppendChild(fillvalue);
                    fromFile.AppendChild(fillsize);

                    xmlRoot.AppendChild(fromFile);
                }

                xml.Save(xml_path);

                MessageBox.Show("文件列表保存成功", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "异常");
            }

        }

        private void btnLoadList_Click(object sender, EventArgs e)
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

                this.txtBoxDestFile.Text = Path.Combine(exe_path, string.Format("bin_release_{0}.bin", DateTime.Now.ToString("yyyyMMddHHmmss")));

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.StackTrace.ToString(), "异常");
             
             }

        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            if (this.txtBoxDestFile.Text.Length <= 0)
            {
                MessageBox.Show("请设置合并后的目标文件路径。\r\n然后再进行合并。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("至少要有两个文件，才能合并。\r\n请添加要合并的文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.combineThr = new Thread(new ThreadStart(this.CombineMethod));
                this.combineThr.Start();
            }

        }




        private void CombineMethod()
        {
            uint num = 0;
            try
            {
                    BinaryReader reader = null;
                    FileStream output = File.Open(this.txtBoxDestFile.Text.Trim(), FileMode.Create, FileAccess.Write);
                    BinaryWriter writer = new BinaryWriter(output);
                    foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    {
                        uint num2 = Convert.ToUInt32(row.Cells[1].Value.ToString(), 0x10);
                        if ((num2 > 0) && (num < (num2 - 1)))
                        {
                            if (Convert.ToInt32(row.Cells[2].Value) == 1)
                            {
                                this.fillvalue = uint.MaxValue;
                            }
                            else
                            {
                                this.fillvalue = 0;
                            }
                            while (num < num2)
                            {
                                writer.Write(this.fillvalue);
                                num += 4;
                            }
                            writer.Flush();
                        }
                        FileStream input = File.Open(row.Cells[0].Value.ToString(), FileMode.Open, FileAccess.Read);
                        reader = new BinaryReader(input);
                        reader.BaseStream.Seek(0L, SeekOrigin.Begin);
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            uint num3 = reader.ReadUInt32();
                            writer.Write(num3);
                            num += 4;
                        }
                        writer.Flush();
                        input.Close();
                    }
                    writer.Close();
                    output.Close();

                    MessageBox.Show("合并完成!!!");
            }catch
            {
                 MessageBox.Show("合并异常!!!");
            }

        }

        private void MainFrm_Shown(object sender, EventArgs e)
        {
            exe_path = Application.StartupPath;
        }

        /// <summary>
        /// 计算文件大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileSize_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow tmpRow in this.dataGridView1.Rows)
                    {
                        FileInfo info = new FileInfo(Convert.ToString(tmpRow.Cells[0].Value));
                        tmpRow.Cells[3].Value = info.Length;
                    }

                    MessageBox.Show("文件大小计算完成", "提示");

                }
                else
                {
                    MessageBox.Show("没有文件记录", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "异常");
            }
        }

    }
}
