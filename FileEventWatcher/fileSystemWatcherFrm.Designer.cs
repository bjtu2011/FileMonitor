namespace FileEventWatcher
{
    partial class fileSystemWatcherFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileSystemWatcherFrm));
            this.fileEventLog_lvw = new System.Windows.Forms.ListView();
            this.fileEventLog_ch1 = new System.Windows.Forms.ColumnHeader();
            this.fileEventLog_ch2 = new System.Windows.Forms.ColumnHeader();
            this.fileEventLog_ch3 = new System.Windows.Forms.ColumnHeader();
            this.fileEventLog_ch7 = new System.Windows.Forms.ColumnHeader();
            this.fileEventLog_ch4 = new System.Windows.Forms.ColumnHeader();
            this.fileEventLog_ch5 = new System.Windows.Forms.ColumnHeader();
            this.fileEventLog_ch6 = new System.Windows.Forms.ColumnHeader();
            this.fileWatcher_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quickSelect_rbtn = new System.Windows.Forms.RadioButton();
            this.filePath_txt = new System.Windows.Forms.TextBox();
            this.spcifiedFloder_rbtn = new System.Windows.Forms.RadioButton();
            this.allDisk_chk = new System.Windows.Forms.CheckBox();
            this.dir_lvw = new System.Windows.Forms.ListView();
            this.fileWatcherPath_btn = new System.Windows.Forms.Button();
            this.fileWatcher_tools = new System.Windows.Forms.ToolStrip();
            this.start_tsbtn = new System.Windows.Forms.ToolStripButton();
            this.stop_tsbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clear_tsbtn = new System.Windows.Forms.ToolStripButton();
            this.save_tsbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.file_ilst = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.filePathSet_tab = new System.Windows.Forms.TabPage();
            this.fileTypeSet_tab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subDirWatcher_chk = new System.Windows.Forms.CheckBox();
            this.versionInfo_tsbtn = new System.Windows.Forms.ToolStripButton();
            this.fileWatcher_cms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.fileWatcher_tools.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.filePathSet_tab.SuspendLayout();
            this.fileTypeSet_tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileEventLog_lvw
            // 
            this.fileEventLog_lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileEventLog_ch1,
            this.fileEventLog_ch2,
            this.fileEventLog_ch3,
            this.fileEventLog_ch7,
            this.fileEventLog_ch4,
            this.fileEventLog_ch5,
            this.fileEventLog_ch6});
            this.fileEventLog_lvw.ContextMenuStrip = this.fileWatcher_cms;
            this.fileEventLog_lvw.FullRowSelect = true;
            this.fileEventLog_lvw.GridLines = true;
            this.fileEventLog_lvw.Location = new System.Drawing.Point(11, 37);
            this.fileEventLog_lvw.Name = "fileEventLog_lvw";
            this.fileEventLog_lvw.Size = new System.Drawing.Size(635, 377);
            this.fileEventLog_lvw.TabIndex = 0;
            this.fileEventLog_lvw.UseCompatibleStateImageBehavior = false;
            this.fileEventLog_lvw.View = System.Windows.Forms.View.Details;
            // 
            // fileEventLog_ch1
            // 
            this.fileEventLog_ch1.Text = "";
            this.fileEventLog_ch1.Width = 27;
            // 
            // fileEventLog_ch2
            // 
            this.fileEventLog_ch2.Text = "时间";
            this.fileEventLog_ch2.Width = 120;
            // 
            // fileEventLog_ch3
            // 
            this.fileEventLog_ch3.Text = "事件";
            this.fileEventLog_ch3.Width = 70;
            // 
            // fileEventLog_ch7
            // 
            this.fileEventLog_ch7.Text = "硬盘";
            this.fileEventLog_ch7.Width = 45;
            // 
            // fileEventLog_ch4
            // 
            this.fileEventLog_ch4.Text = "文件";
            this.fileEventLog_ch4.Width = 156;
            // 
            // fileEventLog_ch5
            // 
            this.fileEventLog_ch5.Text = "路径";
            this.fileEventLog_ch5.Width = 250;
            // 
            // fileEventLog_ch6
            // 
            this.fileEventLog_ch6.Text = "说明";
            this.fileEventLog_ch6.Width = 350;
            // 
            // fileWatcher_cms
            // 
            this.fileWatcher_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem,
            this.打开目录ToolStripMenuItem});
            this.fileWatcher_cms.Name = "fileWatcher_cms";
            this.fileWatcher_cms.Size = new System.Drawing.Size(149, 48);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            // 
            // 打开目录ToolStripMenuItem
            // 
            this.打开目录ToolStripMenuItem.Name = "打开目录ToolStripMenuItem";
            this.打开目录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开目录ToolStripMenuItem.Text = "打开文件目录";
            this.打开目录ToolStripMenuItem.Click += new System.EventHandler(this.打开目录ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quickSelect_rbtn);
            this.groupBox1.Controls.Add(this.filePath_txt);
            this.groupBox1.Controls.Add(this.spcifiedFloder_rbtn);
            this.groupBox1.Controls.Add(this.allDisk_chk);
            this.groupBox1.Controls.Add(this.dir_lvw);
            this.groupBox1.Controls.Add(this.fileWatcherPath_btn);
            this.groupBox1.Location = new System.Drawing.Point(17, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 230);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // quickSelect_rbtn
            // 
            this.quickSelect_rbtn.AutoSize = true;
            this.quickSelect_rbtn.Checked = true;
            this.quickSelect_rbtn.Location = new System.Drawing.Point(18, 62);
            this.quickSelect_rbtn.Name = "quickSelect_rbtn";
            this.quickSelect_rbtn.Size = new System.Drawing.Size(83, 16);
            this.quickSelect_rbtn.TabIndex = 12;
            this.quickSelect_rbtn.TabStop = true;
            this.quickSelect_rbtn.Text = "快捷选择：";
            this.quickSelect_rbtn.UseVisualStyleBackColor = true;
            // 
            // filePath_txt
            // 
            this.filePath_txt.Location = new System.Drawing.Point(109, 21);
            this.filePath_txt.Name = "filePath_txt";
            this.filePath_txt.Size = new System.Drawing.Size(274, 21);
            this.filePath_txt.TabIndex = 11;
            // 
            // spcifiedFloder_rbtn
            // 
            this.spcifiedFloder_rbtn.AutoSize = true;
            this.spcifiedFloder_rbtn.Location = new System.Drawing.Point(20, 24);
            this.spcifiedFloder_rbtn.Name = "spcifiedFloder_rbtn";
            this.spcifiedFloder_rbtn.Size = new System.Drawing.Size(83, 16);
            this.spcifiedFloder_rbtn.TabIndex = 10;
            this.spcifiedFloder_rbtn.TabStop = true;
            this.spcifiedFloder_rbtn.Text = "指定文件：";
            this.spcifiedFloder_rbtn.UseVisualStyleBackColor = true;
            // 
            // allDisk_chk
            // 
            this.allDisk_chk.AutoSize = true;
            this.allDisk_chk.Location = new System.Drawing.Point(37, 84);
            this.allDisk_chk.Name = "allDisk_chk";
            this.allDisk_chk.Size = new System.Drawing.Size(48, 16);
            this.allDisk_chk.TabIndex = 9;
            this.allDisk_chk.Text = "全盘";
            this.allDisk_chk.UseVisualStyleBackColor = true;
            this.allDisk_chk.CheckedChanged += new System.EventHandler(this.allDisk_chk_CheckedChanged);
            // 
            // dir_lvw
            // 
            this.dir_lvw.CheckBoxes = true;
            this.dir_lvw.Location = new System.Drawing.Point(106, 62);
            this.dir_lvw.Name = "dir_lvw";
            this.dir_lvw.Size = new System.Drawing.Size(442, 155);
            this.dir_lvw.TabIndex = 8;
            this.dir_lvw.UseCompatibleStateImageBehavior = false;
            this.dir_lvw.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.dir_lvw_ItemCheck);
            // 
            // fileWatcherPath_btn
            // 
            this.fileWatcherPath_btn.Location = new System.Drawing.Point(407, 20);
            this.fileWatcherPath_btn.Name = "fileWatcherPath_btn";
            this.fileWatcherPath_btn.Size = new System.Drawing.Size(75, 23);
            this.fileWatcherPath_btn.TabIndex = 5;
            this.fileWatcherPath_btn.Text = "选择...";
            this.fileWatcherPath_btn.UseVisualStyleBackColor = true;
            this.fileWatcherPath_btn.Click += new System.EventHandler(this.fileWatcherPath_btn_Click);
            // 
            // fileWatcher_tools
            // 
            this.fileWatcher_tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_tsbtn,
            this.stop_tsbtn,
            this.toolStripSeparator1,
            this.clear_tsbtn,
            this.save_tsbtn,
            this.toolStripSeparator2,
            this.versionInfo_tsbtn});
            this.fileWatcher_tools.Location = new System.Drawing.Point(0, 0);
            this.fileWatcher_tools.Name = "fileWatcher_tools";
            this.fileWatcher_tools.Size = new System.Drawing.Size(659, 25);
            this.fileWatcher_tools.TabIndex = 4;
            this.fileWatcher_tools.Text = "toolStrip1";
            // 
            // start_tsbtn
            // 
            this.start_tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("start_tsbtn.Image")));
            this.start_tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.start_tsbtn.Name = "start_tsbtn";
            this.start_tsbtn.Size = new System.Drawing.Size(52, 22);
            this.start_tsbtn.Text = "开始";
            this.start_tsbtn.Click += new System.EventHandler(this.start_tsbtn_Click);
            // 
            // stop_tsbtn
            // 
            this.stop_tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("stop_tsbtn.Image")));
            this.stop_tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stop_tsbtn.Name = "stop_tsbtn";
            this.stop_tsbtn.Size = new System.Drawing.Size(52, 22);
            this.stop_tsbtn.Text = "停止";
            this.stop_tsbtn.Click += new System.EventHandler(this.stop_tsbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // clear_tsbtn
            // 
            this.clear_tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("clear_tsbtn.Image")));
            this.clear_tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clear_tsbtn.Name = "clear_tsbtn";
            this.clear_tsbtn.Size = new System.Drawing.Size(52, 22);
            this.clear_tsbtn.Text = "清空";
            this.clear_tsbtn.Click += new System.EventHandler(this.clear_tsbtn_Click);
            // 
            // save_tsbtn
            // 
            this.save_tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("save_tsbtn.Image")));
            this.save_tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_tsbtn.Name = "save_tsbtn";
            this.save_tsbtn.Size = new System.Drawing.Size(52, 22);
            this.save_tsbtn.Text = "保存";
            this.save_tsbtn.Click += new System.EventHandler(this.save_tsbtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // file_ilst
            // 
            this.file_ilst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("file_ilst.ImageStream")));
            this.file_ilst.TransparentColor = System.Drawing.Color.Transparent;
            this.file_ilst.Images.SetKeyName(0, "dirIcon.png");
            this.file_ilst.Images.SetKeyName(1, "removableDisk.png");
            this.file_ilst.Images.SetKeyName(2, "file.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.filePathSet_tab);
            this.tabControl1.Controls.Add(this.fileTypeSet_tab);
            this.tabControl1.Location = new System.Drawing.Point(11, 431);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 272);
            this.tabControl1.TabIndex = 5;
            // 
            // filePathSet_tab
            // 
            this.filePathSet_tab.Controls.Add(this.groupBox1);
            this.filePathSet_tab.Location = new System.Drawing.Point(4, 22);
            this.filePathSet_tab.Name = "filePathSet_tab";
            this.filePathSet_tab.Padding = new System.Windows.Forms.Padding(3);
            this.filePathSet_tab.Size = new System.Drawing.Size(628, 246);
            this.filePathSet_tab.TabIndex = 0;
            this.filePathSet_tab.Text = "监控目录设置";
            this.filePathSet_tab.UseVisualStyleBackColor = true;
            // 
            // fileTypeSet_tab
            // 
            this.fileTypeSet_tab.Controls.Add(this.groupBox2);
            this.fileTypeSet_tab.Location = new System.Drawing.Point(4, 22);
            this.fileTypeSet_tab.Name = "fileTypeSet_tab";
            this.fileTypeSet_tab.Padding = new System.Windows.Forms.Padding(3);
            this.fileTypeSet_tab.Size = new System.Drawing.Size(628, 246);
            this.fileTypeSet_tab.TabIndex = 1;
            this.fileTypeSet_tab.Text = "监控文件类型设置";
            this.fileTypeSet_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.subDirWatcher_chk);
            this.groupBox2.Location = new System.Drawing.Point(20, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 222);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // subDirWatcher_chk
            // 
            this.subDirWatcher_chk.AutoSize = true;
            this.subDirWatcher_chk.Checked = true;
            this.subDirWatcher_chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subDirWatcher_chk.Location = new System.Drawing.Point(19, 30);
            this.subDirWatcher_chk.Name = "subDirWatcher_chk";
            this.subDirWatcher_chk.Size = new System.Drawing.Size(108, 16);
            this.subDirWatcher_chk.TabIndex = 0;
            this.subDirWatcher_chk.Text = "子目录级联监控";
            this.subDirWatcher_chk.UseVisualStyleBackColor = true;
            // 
            // versionInfo_tsbtn
            // 
            this.versionInfo_tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("versionInfo_tsbtn.Image")));
            this.versionInfo_tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.versionInfo_tsbtn.Name = "versionInfo_tsbtn";
            this.versionInfo_tsbtn.Size = new System.Drawing.Size(76, 22);
            this.versionInfo_tsbtn.Text = "版本说明";
            // 
            // fileSystemWatcherFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 707);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fileWatcher_tools);
            this.Controls.Add(this.fileEventLog_lvw);
            this.Name = "fileSystemWatcherFrm";
            this.Text = "文件监控";
            this.Load += new System.EventHandler(this.fileSystemWatcherFrm_Load);
            this.fileWatcher_cms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fileWatcher_tools.ResumeLayout(false);
            this.fileWatcher_tools.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.filePathSet_tab.ResumeLayout(false);
            this.fileTypeSet_tab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView fileEventLog_lvw;
        private System.Windows.Forms.ColumnHeader fileEventLog_ch1;
        private System.Windows.Forms.ColumnHeader fileEventLog_ch2;
        private System.Windows.Forms.ColumnHeader fileEventLog_ch3;
        private System.Windows.Forms.ColumnHeader fileEventLog_ch4;
        private System.Windows.Forms.ColumnHeader fileEventLog_ch5;
        private System.Windows.Forms.ColumnHeader fileEventLog_ch6;
        private System.Windows.Forms.ColumnHeader fileEventLog_ch7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fileWatcherPath_btn;
        private System.Windows.Forms.ToolStrip fileWatcher_tools;
        private System.Windows.Forms.ToolStripButton start_tsbtn;
        private System.Windows.Forms.ToolStripButton stop_tsbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton clear_tsbtn;
        private System.Windows.Forms.ToolStripButton save_tsbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip fileWatcher_cms;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开目录ToolStripMenuItem;
        private System.Windows.Forms.ListView dir_lvw;
        private System.Windows.Forms.ImageList file_ilst;
        private System.Windows.Forms.CheckBox allDisk_chk;
        private System.Windows.Forms.RadioButton spcifiedFloder_rbtn;
        private System.Windows.Forms.TextBox filePath_txt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage filePathSet_tab;
        private System.Windows.Forms.TabPage fileTypeSet_tab;
        private System.Windows.Forms.RadioButton quickSelect_rbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox subDirWatcher_chk;
        private System.Windows.Forms.ToolStripButton versionInfo_tsbtn;
    }
}

