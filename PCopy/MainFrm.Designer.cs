namespace PCopy
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSrcFile = new System.Windows.Forms.TextBox();
            this.btnSrcFile = new System.Windows.Forms.Button();
            this.btnCopyTo = new System.Windows.Forms.Button();
            this.txtBoxTargetFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRootPath = new System.Windows.Forms.TextBox();
            this.btnRootPath = new System.Windows.Forms.Button();
            this.btnFileCopy = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnReadXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFile,
            this.ColumnSrc,
            this.ColumnTarget});
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(707, 630);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnFile
            // 
            this.ColumnFile.Frozen = true;
            this.ColumnFile.HeaderText = "序号";
            this.ColumnFile.Name = "ColumnFile";
            this.ColumnFile.ReadOnly = true;
            this.ColumnFile.Width = 80;
            // 
            // ColumnSrc
            // 
            this.ColumnSrc.Frozen = true;
            this.ColumnSrc.HeaderText = "源文件";
            this.ColumnSrc.Name = "ColumnSrc";
            this.ColumnSrc.ReadOnly = true;
            this.ColumnSrc.Width = 300;
            // 
            // ColumnTarget
            // 
            this.ColumnTarget.Frozen = true;
            this.ColumnTarget.HeaderText = "复制到";
            this.ColumnTarget.Name = "ColumnTarget";
            this.ColumnTarget.ReadOnly = true;
            this.ColumnTarget.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "源文件:";
            // 
            // txtBoxSrcFile
            // 
            this.txtBoxSrcFile.Location = new System.Drawing.Point(3, 35);
            this.txtBoxSrcFile.Name = "txtBoxSrcFile";
            this.txtBoxSrcFile.ReadOnly = true;
            this.txtBoxSrcFile.Size = new System.Drawing.Size(195, 21);
            this.txtBoxSrcFile.TabIndex = 2;
            this.txtBoxSrcFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSrcFile
            // 
            this.btnSrcFile.Location = new System.Drawing.Point(123, 62);
            this.btnSrcFile.Name = "btnSrcFile";
            this.btnSrcFile.Size = new System.Drawing.Size(75, 23);
            this.btnSrcFile.TabIndex = 3;
            this.btnSrcFile.Text = "选择源文件";
            this.btnSrcFile.UseVisualStyleBackColor = true;
            this.btnSrcFile.Click += new System.EventHandler(this.btnSrcFile_Click);
            // 
            // btnCopyTo
            // 
            this.btnCopyTo.Location = new System.Drawing.Point(126, 146);
            this.btnCopyTo.Name = "btnCopyTo";
            this.btnCopyTo.Size = new System.Drawing.Size(75, 23);
            this.btnCopyTo.TabIndex = 6;
            this.btnCopyTo.Text = "选择复制到";
            this.btnCopyTo.UseVisualStyleBackColor = true;
            this.btnCopyTo.Click += new System.EventHandler(this.btnCopyTo_Click);
            // 
            // txtBoxTargetFile
            // 
            this.txtBoxTargetFile.Location = new System.Drawing.Point(6, 119);
            this.txtBoxTargetFile.Name = "txtBoxTargetFile";
            this.txtBoxTargetFile.Size = new System.Drawing.Size(195, 21);
            this.txtBoxTargetFile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "复制到:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtBoxTargetFile);
            this.groupBox1.Controls.Add(this.btnCopyTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxSrcFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSrcFile);
            this.groupBox1.Location = new System.Drawing.Point(744, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(138, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(77, 190);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(45, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "复制到根目录：";
            // 
            // txtBoxRootPath
            // 
            this.txtBoxRootPath.Location = new System.Drawing.Point(743, 29);
            this.txtBoxRootPath.Name = "txtBoxRootPath";
            this.txtBoxRootPath.ReadOnly = true;
            this.txtBoxRootPath.Size = new System.Drawing.Size(204, 21);
            this.txtBoxRootPath.TabIndex = 9;
            // 
            // btnRootPath
            // 
            this.btnRootPath.Location = new System.Drawing.Point(876, 56);
            this.btnRootPath.Name = "btnRootPath";
            this.btnRootPath.Size = new System.Drawing.Size(75, 23);
            this.btnRootPath.TabIndex = 10;
            this.btnRootPath.Text = "选择根目录 ";
            this.btnRootPath.UseVisualStyleBackColor = true;
            this.btnRootPath.Click += new System.EventHandler(this.btnRootPath_Click);
            // 
            // btnFileCopy
            // 
            this.btnFileCopy.Location = new System.Drawing.Point(747, 358);
            this.btnFileCopy.Name = "btnFileCopy";
            this.btnFileCopy.Size = new System.Drawing.Size(204, 73);
            this.btnFileCopy.TabIndex = 11;
            this.btnFileCopy.Text = "文件复制";
            this.btnFileCopy.UseVisualStyleBackColor = true;
            this.btnFileCopy.Click += new System.EventHandler(this.btnFileCopy_Click);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Location = new System.Drawing.Point(862, 485);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(75, 23);
            this.btnSaveXml.TabIndex = 12;
            this.btnSaveXml.Text = "保存列表";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(862, 514);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(75, 23);
            this.btnReadXml.TabIndex = 13;
            this.btnReadXml.Text = "读取列表";
            this.btnReadXml.UseVisualStyleBackColor = true;
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 654);
            this.Controls.Add(this.btnReadXml);
            this.Controls.Add(this.btnSaveXml);
            this.Controls.Add(this.btnFileCopy);
            this.Controls.Add(this.btnRootPath);
            this.Controls.Add(this.txtBoxRootPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件复制";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSrcFile;
        private System.Windows.Forms.Button btnSrcFile;
        private System.Windows.Forms.Button btnCopyTo;
        private System.Windows.Forms.TextBox txtBoxTargetFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxRootPath;
        private System.Windows.Forms.Button btnRootPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarget;
        private System.Windows.Forms.Button btnFileCopy;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnReadXml;
    }
}

