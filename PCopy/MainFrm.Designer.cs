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
            this.txtBoxSrcFile = new System.Windows.Forms.TextBox();
            this.btnSrcFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnReadXml = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxTargetFile = new System.Windows.Forms.TextBox();
            this.btnCopyTo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRootPath = new System.Windows.Forms.Button();
            this.txtBoxRootPath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnALLTS = new System.Windows.Forms.Button();
            this.btnALLST = new System.Windows.Forms.Button();
            this.btnTS = new System.Windows.Forms.Button();
            this.btnST = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTargetPath = new System.Windows.Forms.Button();
            this.txtBoxTargetPath = new System.Windows.Forms.TextBox();
            this.btnOpenDirectorySrc = new System.Windows.Forms.Button();
            this.btnOpenDirectoryTarget = new System.Windows.Forms.Button();
            this.ColumnFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSrcLastTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSrcFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTLastTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.ColumnSrcLastTime,
            this.ColumnSrcFileSize,
            this.ColumnTarget,
            this.ColumnTLastTime,
            this.ColumnTFileSize,
            this.ColumnStatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 675);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtBoxSrcFile
            // 
            this.txtBoxSrcFile.Location = new System.Drawing.Point(8, 18);
            this.txtBoxSrcFile.Multiline = true;
            this.txtBoxSrcFile.Name = "txtBoxSrcFile";
            this.txtBoxSrcFile.Size = new System.Drawing.Size(206, 70);
            this.txtBoxSrcFile.TabIndex = 2;
            // 
            // btnSrcFile
            // 
            this.btnSrcFile.Location = new System.Drawing.Point(118, 94);
            this.btnSrcFile.Name = "btnSrcFile";
            this.btnSrcFile.Size = new System.Drawing.Size(97, 23);
            this.btnSrcFile.TabIndex = 3;
            this.btnSrcFile.Text = "选择当前文件";
            this.btnSrcFile.UseVisualStyleBackColor = true;
            this.btnSrcFile.Click += new System.EventHandler(this.btnSrcFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenDirectorySrc);
            this.groupBox1.Controls.Add(this.txtBoxSrcFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSrcFile);
            this.groupBox1.Location = new System.Drawing.Point(795, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 121);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前文件";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(933, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(875, 471);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(45, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(818, 471);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Location = new System.Drawing.Point(818, 641);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(75, 23);
            this.btnSaveXml.TabIndex = 12;
            this.btnSaveXml.Text = "保存列表";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(904, 641);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(75, 23);
            this.btnReadXml.TabIndex = 13;
            this.btnReadXml.Text = "读取列表";
            this.btnReadXml.UseVisualStyleBackColor = true;
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenDirectoryTarget);
            this.groupBox2.Controls.Add(this.txtBoxTargetFile);
            this.groupBox2.Controls.Add(this.btnCopyTo);
            this.groupBox2.Location = new System.Drawing.Point(795, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 112);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "目标文件";
            // 
            // txtBoxTargetFile
            // 
            this.txtBoxTargetFile.Location = new System.Drawing.Point(8, 18);
            this.txtBoxTargetFile.Multiline = true;
            this.txtBoxTargetFile.Name = "txtBoxTargetFile";
            this.txtBoxTargetFile.Size = new System.Drawing.Size(206, 62);
            this.txtBoxTargetFile.TabIndex = 7;
            // 
            // btnCopyTo
            // 
            this.btnCopyTo.Location = new System.Drawing.Point(113, 85);
            this.btnCopyTo.Name = "btnCopyTo";
            this.btnCopyTo.Size = new System.Drawing.Size(102, 23);
            this.btnCopyTo.TabIndex = 8;
            this.btnCopyTo.Text = "选择目标文件";
            this.btnCopyTo.UseVisualStyleBackColor = true;
            this.btnCopyTo.Click += new System.EventHandler(this.btnCopyTo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRootPath);
            this.groupBox3.Controls.Add(this.txtBoxRootPath);
            this.groupBox3.Location = new System.Drawing.Point(796, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 95);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "工作目录";
            // 
            // btnRootPath
            // 
            this.btnRootPath.Location = new System.Drawing.Point(111, 66);
            this.btnRootPath.Name = "btnRootPath";
            this.btnRootPath.Size = new System.Drawing.Size(104, 23);
            this.btnRootPath.TabIndex = 12;
            this.btnRootPath.Text = "选择工作目录 ";
            this.btnRootPath.UseVisualStyleBackColor = true;
            this.btnRootPath.Click += new System.EventHandler(this.btnRootPath_Click);
            // 
            // txtBoxRootPath
            // 
            this.txtBoxRootPath.Location = new System.Drawing.Point(8, 20);
            this.txtBoxRootPath.Multiline = true;
            this.txtBoxRootPath.Name = "txtBoxRootPath";
            this.txtBoxRootPath.ReadOnly = true;
            this.txtBoxRootPath.Size = new System.Drawing.Size(204, 43);
            this.txtBoxRootPath.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearStatus);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnCompare);
            this.groupBox4.Controls.Add(this.btnALLTS);
            this.groupBox4.Controls.Add(this.btnALLST);
            this.groupBox4.Controls.Add(this.btnTS);
            this.groupBox4.Controls.Add(this.btnST);
            this.groupBox4.Location = new System.Drawing.Point(794, 506);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 129);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "复制";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(119, 71);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "刷新文件";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(19, 71);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "对比";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnALLTS
            // 
            this.btnALLTS.Location = new System.Drawing.Point(119, 46);
            this.btnALLTS.Name = "btnALLTS";
            this.btnALLTS.Size = new System.Drawing.Size(75, 23);
            this.btnALLTS.TabIndex = 3;
            this.btnALLTS.Text = "ALL S<-T";
            this.btnALLTS.UseVisualStyleBackColor = true;
            this.btnALLTS.Click += new System.EventHandler(this.btnALLTS_Click);
            // 
            // btnALLST
            // 
            this.btnALLST.Location = new System.Drawing.Point(19, 46);
            this.btnALLST.Name = "btnALLST";
            this.btnALLST.Size = new System.Drawing.Size(75, 23);
            this.btnALLST.TabIndex = 2;
            this.btnALLST.Text = "ALL S->T";
            this.btnALLST.UseVisualStyleBackColor = true;
            this.btnALLST.Click += new System.EventHandler(this.btnALLST_Click);
            // 
            // btnTS
            // 
            this.btnTS.Location = new System.Drawing.Point(119, 19);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(75, 23);
            this.btnTS.TabIndex = 1;
            this.btnTS.Text = "S<-T";
            this.btnTS.UseVisualStyleBackColor = true;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // btnST
            // 
            this.btnST.Location = new System.Drawing.Point(19, 19);
            this.btnST.Name = "btnST";
            this.btnST.Size = new System.Drawing.Size(75, 23);
            this.btnST.TabIndex = 0;
            this.btnST.Text = "S->T";
            this.btnST.UseVisualStyleBackColor = true;
            this.btnST.Click += new System.EventHandler(this.btnST_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTargetPath);
            this.groupBox5.Controls.Add(this.txtBoxTargetPath);
            this.groupBox5.Location = new System.Drawing.Point(795, 114);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(223, 95);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "目标目录";
            // 
            // btnTargetPath
            // 
            this.btnTargetPath.Location = new System.Drawing.Point(111, 66);
            this.btnTargetPath.Name = "btnTargetPath";
            this.btnTargetPath.Size = new System.Drawing.Size(104, 23);
            this.btnTargetPath.TabIndex = 12;
            this.btnTargetPath.Text = "选择目标目录 ";
            this.btnTargetPath.UseVisualStyleBackColor = true;
            this.btnTargetPath.Click += new System.EventHandler(this.btnTargetPath_Click);
            // 
            // txtBoxTargetPath
            // 
            this.txtBoxTargetPath.Location = new System.Drawing.Point(8, 20);
            this.txtBoxTargetPath.Multiline = true;
            this.txtBoxTargetPath.Name = "txtBoxTargetPath";
            this.txtBoxTargetPath.ReadOnly = true;
            this.txtBoxTargetPath.Size = new System.Drawing.Size(204, 43);
            this.txtBoxTargetPath.TabIndex = 11;
            // 
            // btnOpenDirectorySrc
            // 
            this.btnOpenDirectorySrc.Location = new System.Drawing.Point(31, 94);
            this.btnOpenDirectorySrc.Name = "btnOpenDirectorySrc";
            this.btnOpenDirectorySrc.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDirectorySrc.TabIndex = 5;
            this.btnOpenDirectorySrc.Text = "打开目录";
            this.btnOpenDirectorySrc.UseVisualStyleBackColor = true;
            this.btnOpenDirectorySrc.Click += new System.EventHandler(this.btnOpenDirectorySrc_Click);
            // 
            // btnOpenDirectoryTarget
            // 
            this.btnOpenDirectoryTarget.Location = new System.Drawing.Point(31, 86);
            this.btnOpenDirectoryTarget.Name = "btnOpenDirectoryTarget";
            this.btnOpenDirectoryTarget.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDirectoryTarget.TabIndex = 9;
            this.btnOpenDirectoryTarget.Text = "打开目录";
            this.btnOpenDirectoryTarget.UseVisualStyleBackColor = true;
            this.btnOpenDirectoryTarget.Click += new System.EventHandler(this.btnOpenDirectoryTarget_Click);
            // 
            // ColumnFile
            // 
            this.ColumnFile.DataPropertyName = "ListID";
            this.ColumnFile.Frozen = true;
            this.ColumnFile.HeaderText = "序号";
            this.ColumnFile.MinimumWidth = 10;
            this.ColumnFile.Name = "ColumnFile";
            this.ColumnFile.ReadOnly = true;
            this.ColumnFile.Width = 60;
            // 
            // ColumnSrc
            // 
            this.ColumnSrc.DataPropertyName = "SrcFile";
            this.ColumnSrc.Frozen = true;
            this.ColumnSrc.HeaderText = "当前文件";
            this.ColumnSrc.MinimumWidth = 10;
            this.ColumnSrc.Name = "ColumnSrc";
            this.ColumnSrc.ReadOnly = true;
            this.ColumnSrc.Width = 120;
            // 
            // ColumnSrcLastTime
            // 
            this.ColumnSrcLastTime.DataPropertyName = "SrcLastTime";
            this.ColumnSrcLastTime.Frozen = true;
            this.ColumnSrcLastTime.HeaderText = "S最后时间";
            this.ColumnSrcLastTime.MinimumWidth = 10;
            this.ColumnSrcLastTime.Name = "ColumnSrcLastTime";
            this.ColumnSrcLastTime.ReadOnly = true;
            // 
            // ColumnSrcFileSize
            // 
            this.ColumnSrcFileSize.DataPropertyName = "SrcFileSize";
            this.ColumnSrcFileSize.Frozen = true;
            this.ColumnSrcFileSize.HeaderText = "S大小";
            this.ColumnSrcFileSize.MinimumWidth = 10;
            this.ColumnSrcFileSize.Name = "ColumnSrcFileSize";
            this.ColumnSrcFileSize.ReadOnly = true;
            this.ColumnSrcFileSize.Width = 80;
            // 
            // ColumnTarget
            // 
            this.ColumnTarget.DataPropertyName = "TargetFile";
            this.ColumnTarget.Frozen = true;
            this.ColumnTarget.HeaderText = "目标文件";
            this.ColumnTarget.MinimumWidth = 10;
            this.ColumnTarget.Name = "ColumnTarget";
            this.ColumnTarget.ReadOnly = true;
            this.ColumnTarget.Width = 120;
            // 
            // ColumnTLastTime
            // 
            this.ColumnTLastTime.DataPropertyName = "TLastTime";
            this.ColumnTLastTime.HeaderText = "T最后时间";
            this.ColumnTLastTime.MinimumWidth = 10;
            this.ColumnTLastTime.Name = "ColumnTLastTime";
            this.ColumnTLastTime.ReadOnly = true;
            // 
            // ColumnTFileSize
            // 
            this.ColumnTFileSize.DataPropertyName = "TFileSize";
            this.ColumnTFileSize.HeaderText = "T大小";
            this.ColumnTFileSize.MinimumWidth = 10;
            this.ColumnTFileSize.Name = "ColumnTFileSize";
            this.ColumnTFileSize.ReadOnly = true;
            this.ColumnTFileSize.Width = 80;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.DataPropertyName = "Status";
            this.ColumnStatus.HeaderText = "状态";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // btnClearStatus
            // 
            this.btnClearStatus.Location = new System.Drawing.Point(119, 100);
            this.btnClearStatus.Name = "btnClearStatus";
            this.btnClearStatus.Size = new System.Drawing.Size(75, 23);
            this.btnClearStatus.TabIndex = 6;
            this.btnClearStatus.Text = "清空状态";
            this.btnClearStatus.UseVisualStyleBackColor = true;
            this.btnClearStatus.Click += new System.EventHandler(this.btnClearStatus_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1021, 675);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReadXml);
            this.Controls.Add(this.btnSaveXml);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件复制";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxSrcFile;
        private System.Windows.Forms.Button btnSrcFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnReadXml;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxTargetFile;
        private System.Windows.Forms.Button btnCopyTo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRootPath;
        private System.Windows.Forms.TextBox txtBoxRootPath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTS;
        private System.Windows.Forms.Button btnST;
        private System.Windows.Forms.Button btnALLTS;
        private System.Windows.Forms.Button btnALLST;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnTargetPath;
        private System.Windows.Forms.TextBox txtBoxTargetPath;
        private System.Windows.Forms.Button btnOpenDirectorySrc;
        private System.Windows.Forms.Button btnOpenDirectoryTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSrcLastTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSrcFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTLastTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.Button btnClearStatus;
    }
}

