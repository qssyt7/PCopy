namespace bincombine
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDestFile = new System.Windows.Forms.TextBox();
            this.btnTargtFile = new System.Windows.Forms.Button();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.btnLoadList = new System.Windows.Forms.Button();
            this.btnCombine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelFile = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnDelFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxFromFile = new System.Windows.Forms.TextBox();
            this.txtBoxOffset = new System.Windows.Forms.TextBox();
            this.rdoBtnFill1 = new System.Windows.Forms.RadioButton();
            this.rdoBtnFill0 = new System.Windows.Forms.RadioButton();
            this.clmfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfilesize = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmfile,
            this.clmOffset,
            this.clmFill,
            this.clmfilesize});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(784, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "合并到：";
            // 
            // txtBoxDestFile
            // 
            this.txtBoxDestFile.Location = new System.Drawing.Point(76, 458);
            this.txtBoxDestFile.Name = "txtBoxDestFile";
            this.txtBoxDestFile.ReadOnly = true;
            this.txtBoxDestFile.Size = new System.Drawing.Size(536, 21);
            this.txtBoxDestFile.TabIndex = 2;
            // 
            // btnTargtFile
            // 
            this.btnTargtFile.Location = new System.Drawing.Point(615, 457);
            this.btnTargtFile.Name = "btnTargtFile";
            this.btnTargtFile.Size = new System.Drawing.Size(74, 23);
            this.btnTargtFile.TabIndex = 3;
            this.btnTargtFile.Text = "设置文件";
            this.btnTargtFile.UseVisualStyleBackColor = true;
            this.btnTargtFile.Click += new System.EventHandler(this.btnTargtFile_Click);
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(715, 459);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(65, 23);
            this.btnSaveList.TabIndex = 3;
            this.btnSaveList.Text = "保存列表";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // btnLoadList
            // 
            this.btnLoadList.Location = new System.Drawing.Point(715, 486);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(65, 23);
            this.btnLoadList.TabIndex = 3;
            this.btnLoadList.Text = "载入列表";
            this.btnLoadList.UseVisualStyleBackColor = true;
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
            // 
            // btnCombine
            // 
            this.btnCombine.Location = new System.Drawing.Point(700, 522);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(77, 36);
            this.btnCombine.TabIndex = 3;
            this.btnCombine.Text = "合并";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBtnFill0);
            this.groupBox1.Controls.Add(this.rdoBtnFill1);
            this.groupBox1.Controls.Add(this.txtBoxOffset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFileSize);
            this.groupBox1.Controls.Add(this.btnAddFile);
            this.groupBox1.Controls.Add(this.btnDelFile);
            this.groupBox1.Controls.Add(this.txtboxFromFile);
            this.groupBox1.Controls.Add(this.btnAbout);
            this.groupBox1.Controls.Add(this.btnSelFile);
            this.groupBox1.Location = new System.Drawing.Point(14, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择要合并的BIN文件";
            // 
            // btnSelFile
            // 
            this.btnSelFile.Location = new System.Drawing.Point(601, 18);
            this.btnSelFile.Name = "btnSelFile";
            this.btnSelFile.Size = new System.Drawing.Size(75, 24);
            this.btnSelFile.TabIndex = 0;
            this.btnSelFile.Text = "选择文件";
            this.btnSelFile.UseVisualStyleBackColor = true;
            this.btnSelFile.Click += new System.EventHandler(this.btnSelFile_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(600, 47);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 24);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "about";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnDelFile
            // 
            this.btnDelFile.Location = new System.Drawing.Point(548, 47);
            this.btnDelFile.Name = "btnDelFile";
            this.btnDelFile.Size = new System.Drawing.Size(51, 24);
            this.btnDelFile.TabIndex = 0;
            this.btnDelFile.Text = "删除";
            this.btnDelFile.UseVisualStyleBackColor = true;
            this.btnDelFile.Click += new System.EventHandler(this.btnDelFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(499, 47);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(46, 24);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "增加";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(246, 54);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(83, 12);
            this.lblFileSize.TabIndex = 1;
            this.lblFileSize.Text = "文件大小为:0B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "BIN文件：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "偏移量：";
            // 
            // txtboxFromFile
            // 
            this.txtboxFromFile.Location = new System.Drawing.Point(65, 20);
            this.txtboxFromFile.Name = "txtboxFromFile";
            this.txtboxFromFile.ReadOnly = true;
            this.txtboxFromFile.Size = new System.Drawing.Size(531, 21);
            this.txtboxFromFile.TabIndex = 2;
            // 
            // txtBoxOffset
            // 
            this.txtBoxOffset.Location = new System.Drawing.Point(62, 49);
            this.txtBoxOffset.MaxLength = 8;
            this.txtBoxOffset.Name = "txtBoxOffset";
            this.txtBoxOffset.Size = new System.Drawing.Size(53, 21);
            this.txtBoxOffset.TabIndex = 3;
            this.txtBoxOffset.Text = "00000000";
            this.txtBoxOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxOffset_KeyPress);
            // 
            // rdoBtnFill1
            // 
            this.rdoBtnFill1.AutoSize = true;
            this.rdoBtnFill1.Checked = true;
            this.rdoBtnFill1.Location = new System.Drawing.Point(124, 52);
            this.rdoBtnFill1.Name = "rdoBtnFill1";
            this.rdoBtnFill1.Size = new System.Drawing.Size(53, 16);
            this.rdoBtnFill1.TabIndex = 4;
            this.rdoBtnFill1.TabStop = true;
            this.rdoBtnFill1.Text = "填充1";
            this.rdoBtnFill1.UseVisualStyleBackColor = true;
            // 
            // rdoBtnFill0
            // 
            this.rdoBtnFill0.AutoSize = true;
            this.rdoBtnFill0.Location = new System.Drawing.Point(176, 52);
            this.rdoBtnFill0.Name = "rdoBtnFill0";
            this.rdoBtnFill0.Size = new System.Drawing.Size(53, 16);
            this.rdoBtnFill0.TabIndex = 4;
            this.rdoBtnFill0.Text = "填充0";
            this.rdoBtnFill0.UseVisualStyleBackColor = true;
            // 
            // clmfile
            // 
            this.clmfile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmfile.HeaderText = "文件名称";
            this.clmfile.Name = "clmfile";
            this.clmfile.ReadOnly = true;
            this.clmfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmfile.Width = 520;
            // 
            // clmOffset
            // 
            this.clmOffset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmOffset.HeaderText = "偏移量（H）";
            this.clmOffset.Name = "clmOffset";
            this.clmOffset.ReadOnly = true;
            this.clmOffset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmOffset.Width = 80;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmFill.HeaderText = "填充";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            this.clmFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFill.Width = 80;
            // 
            // clmfilesize
            // 
            this.clmfilesize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmfilesize.HeaderText = "文件大小（B）";
            this.clmfilesize.Name = "clmfilesize";
            this.clmfilesize.ReadOnly = true;
            this.clmfilesize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCombine);
            this.Controls.Add(this.btnLoadList);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.btnTargtFile);
            this.Controls.Add(this.txtBoxDestFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二进制文件合并工具";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDestFile;
        private System.Windows.Forms.Button btnTargtFile;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.Button btnLoadList;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnDelFile;
        private System.Windows.Forms.TextBox txtboxFromFile;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSelFile;
        private System.Windows.Forms.RadioButton rdoBtnFill0;
        private System.Windows.Forms.RadioButton rdoBtnFill1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfilesize;
    }
}

