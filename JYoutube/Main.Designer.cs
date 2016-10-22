namespace JYoutube
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvTmp = new System.Windows.Forms.ListView();
            this.cmsTemplate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvTemplate = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTmpCollectModeWap = new System.Windows.Forms.RadioButton();
            this.tbTmpCollectLinkA = new System.Windows.Forms.TextBox();
            this.rbTmpCollectModePc = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTmpCollectLinkVideo = new System.Windows.Forms.TextBox();
            this.tbTmpCollectLink = new System.Windows.Forms.TextBox();
            this.tbTmpCollectLinkTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTmpYouTuBeID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTmpYouTuBeName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTmpMake = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cmsTemplate.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvTmp);
            this.tabPage1.Controls.Add(this.lvTemplate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "模板列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvTmp
            // 
            this.lvTmp.ContextMenuStrip = this.cmsTemplate;
            this.lvTmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTmp.FullRowSelect = true;
            this.lvTmp.GridLines = true;
            this.lvTmp.LabelEdit = true;
            this.lvTmp.Location = new System.Drawing.Point(3, 3);
            this.lvTmp.MultiSelect = false;
            this.lvTmp.Name = "lvTmp";
            this.lvTmp.Size = new System.Drawing.Size(570, 530);
            this.lvTmp.TabIndex = 1;
            this.lvTmp.UseCompatibleStateImageBehavior = false;
            this.lvTmp.View = System.Windows.Forms.View.Details;
            // 
            // cmsTemplate
            // 
            this.cmsTemplate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.StopToolStripMenuItem});
            this.cmsTemplate.Name = "cmsTemplate";
            this.cmsTemplate.Size = new System.Drawing.Size(101, 48);
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.StartToolStripMenuItem.Text = "开始";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.StopToolStripMenuItem.Text = "结束";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // lvTemplate
            // 
            this.lvTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTemplate.Location = new System.Drawing.Point(3, 3);
            this.lvTemplate.Name = "lvTemplate";
            this.lvTemplate.Size = new System.Drawing.Size(570, 530);
            this.lvTemplate.TabIndex = 0;
            this.lvTemplate.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(576, 536);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "日志列表";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 12;
            this.lbLog.Location = new System.Drawing.Point(0, 0);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(576, 536);
            this.lbLog.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "制作模板";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbTmpCollectModeWap);
            this.groupBox4.Controls.Add(this.tbTmpCollectLinkA);
            this.groupBox4.Controls.Add(this.rbTmpCollectModePc);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbTmpCollectLinkVideo);
            this.groupBox4.Controls.Add(this.tbTmpCollectLink);
            this.groupBox4.Controls.Add(this.tbTmpCollectLinkTitle);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(570, 209);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "采集信息";
            // 
            // rbTmpCollectModeWap
            // 
            this.rbTmpCollectModeWap.AutoSize = true;
            this.rbTmpCollectModeWap.Location = new System.Drawing.Point(211, 177);
            this.rbTmpCollectModeWap.Name = "rbTmpCollectModeWap";
            this.rbTmpCollectModeWap.Size = new System.Drawing.Size(53, 16);
            this.rbTmpCollectModeWap.TabIndex = 2;
            this.rbTmpCollectModeWap.Text = "Wap端";
            this.rbTmpCollectModeWap.UseVisualStyleBackColor = true;
            // 
            // tbTmpCollectLinkA
            // 
            this.tbTmpCollectLinkA.Location = new System.Drawing.Point(136, 63);
            this.tbTmpCollectLinkA.Name = "tbTmpCollectLinkA";
            this.tbTmpCollectLinkA.Size = new System.Drawing.Size(422, 21);
            this.tbTmpCollectLinkA.TabIndex = 1;
            // 
            // rbTmpCollectModePc
            // 
            this.rbTmpCollectModePc.AutoSize = true;
            this.rbTmpCollectModePc.Checked = true;
            this.rbTmpCollectModePc.Location = new System.Drawing.Point(135, 177);
            this.rbTmpCollectModePc.Name = "rbTmpCollectModePc";
            this.rbTmpCollectModePc.Size = new System.Drawing.Size(47, 16);
            this.rbTmpCollectModePc.TabIndex = 2;
            this.rbTmpCollectModePc.TabStop = true;
            this.rbTmpCollectModePc.Text = "PC端";
            this.rbTmpCollectModePc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "列表链接:";
            // 
            // tbTmpCollectLinkVideo
            // 
            this.tbTmpCollectLinkVideo.Location = new System.Drawing.Point(136, 139);
            this.tbTmpCollectLinkVideo.Name = "tbTmpCollectLinkVideo";
            this.tbTmpCollectLinkVideo.Size = new System.Drawing.Size(422, 21);
            this.tbTmpCollectLinkVideo.TabIndex = 1;
            // 
            // tbTmpCollectLink
            // 
            this.tbTmpCollectLink.Location = new System.Drawing.Point(136, 24);
            this.tbTmpCollectLink.Name = "tbTmpCollectLink";
            this.tbTmpCollectLink.Size = new System.Drawing.Size(422, 21);
            this.tbTmpCollectLink.TabIndex = 1;
            // 
            // tbTmpCollectLinkTitle
            // 
            this.tbTmpCollectLinkTitle.Location = new System.Drawing.Point(136, 102);
            this.tbTmpCollectLinkTitle.Name = "tbTmpCollectLinkTitle";
            this.tbTmpCollectLinkTitle.Size = new System.Drawing.Size(422, 21);
            this.tbTmpCollectLinkTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "列表链接A标签:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "视频页Video标签:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "视频页Video标题:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "模式:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTmpYouTuBeID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbTmpYouTuBeName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 98);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Youtube信息";
            // 
            // tbTmpYouTuBeID
            // 
            this.tbTmpYouTuBeID.Location = new System.Drawing.Point(135, 60);
            this.tbTmpYouTuBeID.Name = "tbTmpYouTuBeID";
            this.tbTmpYouTuBeID.Size = new System.Drawing.Size(422, 21);
            this.tbTmpYouTuBeID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "播放列表ID:";
            // 
            // tbTmpYouTuBeName
            // 
            this.tbTmpYouTuBeName.Location = new System.Drawing.Point(135, 24);
            this.tbTmpYouTuBeName.Name = "tbTmpYouTuBeName";
            this.tbTmpYouTuBeName.Size = new System.Drawing.Size(422, 21);
            this.tbTmpYouTuBeName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "播放列表名称:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTmpMake);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "动作";
            // 
            // btnTmpMake
            // 
            this.btnTmpMake.Location = new System.Drawing.Point(483, 17);
            this.btnTmpMake.Name = "btnTmpMake";
            this.btnTmpMake.Size = new System.Drawing.Size(75, 23);
            this.btnTmpMake.TabIndex = 0;
            this.btnTmpMake.Text = "制作模版";
            this.btnTmpMake.UseVisualStyleBackColor = true;
            this.btnTmpMake.Click += new System.EventHandler(this.btnTmpMake_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTmpName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模版信息";
            // 
            // tbTmpName
            // 
            this.tbTmpName.Location = new System.Drawing.Point(136, 26);
            this.tbTmpName.Name = "tbTmpName";
            this.tbTmpName.Size = new System.Drawing.Size(422, 21);
            this.tbTmpName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "模版名称:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JYoutube";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Leave += new System.EventHandler(this.Main_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cmsTemplate.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvTemplate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvTmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTmpCollectModeWap;
        private System.Windows.Forms.RadioButton rbTmpCollectModePc;
        private System.Windows.Forms.TextBox tbTmpCollectLinkTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTmpCollectLinkA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTmpCollectLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTmpMake;
        private System.Windows.Forms.TextBox tbTmpCollectLinkVideo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTmpYouTuBeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTmpYouTuBeName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip cmsTemplate;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
    }
}

