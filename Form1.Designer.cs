
namespace memo
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放音乐MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停开始sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一首ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一首FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置或更换图片PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clock = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minuate = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.look = new System.Windows.Forms.Button();
            this.music = new System.Windows.Forms.Button();
            this.MusicPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.MusicBox1 = new System.Windows.Forms.ListBox();
            this.Cmusic = new System.Windows.Forms.Button();
            this.ClockBox1 = new System.Windows.Forms.ListBox();
            this.Do = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.播放音乐MToolStripMenuItem,
            this.设置或更换图片PToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.帮助ToolStripMenuItem.Text = "帮助（&H）";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 播放音乐MToolStripMenuItem
            // 
            this.播放音乐MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.暂停开始sToolStripMenuItem,
            this.下一首ToolStripMenuItem,
            this.上一首FToolStripMenuItem});
            this.播放音乐MToolStripMenuItem.Name = "播放音乐MToolStripMenuItem";
            this.播放音乐MToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.播放音乐MToolStripMenuItem.Text = "播放音乐（&M）";
            // 
            // 暂停开始sToolStripMenuItem
            // 
            this.暂停开始sToolStripMenuItem.Name = "暂停开始sToolStripMenuItem";
            this.暂停开始sToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.暂停开始sToolStripMenuItem.Text = "暂停/开始(&s)";
            // 
            // 下一首ToolStripMenuItem
            // 
            this.下一首ToolStripMenuItem.Name = "下一首ToolStripMenuItem";
            this.下一首ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.下一首ToolStripMenuItem.Text = "下一首（&N）";
            this.下一首ToolStripMenuItem.Click += new System.EventHandler(this.下一首ToolStripMenuItem_Click);
            // 
            // 上一首FToolStripMenuItem
            // 
            this.上一首FToolStripMenuItem.Name = "上一首FToolStripMenuItem";
            this.上一首FToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.上一首FToolStripMenuItem.Text = "上一首（&F)";
            // 
            // 设置或更换图片PToolStripMenuItem
            // 
            this.设置或更换图片PToolStripMenuItem.Name = "设置或更换图片PToolStripMenuItem";
            this.设置或更换图片PToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.设置或更换图片PToolStripMenuItem.Text = "设置或更换图片(&P)";
            this.设置或更换图片PToolStripMenuItem.Click += new System.EventHandler(this.设置或更换图片PToolStripMenuItem_Click);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clock.Location = new System.Drawing.Point(5, 42);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(68, 28);
            this.clock.TabIndex = 1;
            this.clock.Text = "闹钟";
            this.clock.MouseHover += new System.EventHandler(this.clock_MouseHover);
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(79, 42);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(39, 25);
            this.hour.TabIndex = 2;
            this.hour.TextChanged += new System.EventHandler(this.hour_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加闹钟";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(418, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer
            // 
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(39, 20);
            this.timer.Text = "时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 10;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(40, 83);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 15);
            this.lblShow.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 12;
            // 
            // minuate
            // 
            this.minuate.Location = new System.Drawing.Point(168, 45);
            this.minuate.Name = "minuate";
            this.minuate.Size = new System.Drawing.Size(45, 25);
            this.minuate.TabIndex = 13;
            this.minuate.TextChanged += new System.EventHandler(this.minuate_TextChanged);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(267, 48);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(47, 25);
            this.second.TabIndex = 14;
            this.second.TextChanged += new System.EventHandler(this.second_TextChanged);
            // 
            // look
            // 
            this.look.Location = new System.Drawing.Point(322, 116);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(85, 39);
            this.look.TabIndex = 15;
            this.look.Text = "查看闹钟";
            this.look.UseVisualStyleBackColor = true;
            this.look.Click += new System.EventHandler(this.button2_Click);
            // 
            // music
            // 
            this.music.Location = new System.Drawing.Point(2, 115);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(89, 39);
            this.music.TabIndex = 16;
            this.music.Text = "添加音乐";
            this.music.UseVisualStyleBackColor = true;
            this.music.Click += new System.EventHandler(this.music_Click);
            // 
            // MusicPlayer1
            // 
            this.MusicPlayer1.Enabled = true;
            this.MusicPlayer1.Location = new System.Drawing.Point(382, 57);
            this.MusicPlayer1.Name = "MusicPlayer1";
            this.MusicPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer1.OcxState")));
            this.MusicPlayer1.Size = new System.Drawing.Size(75, 23);
            this.MusicPlayer1.TabIndex = 17;
            // 
            // MusicBox1
            // 
            this.MusicBox1.FormattingEnabled = true;
            this.MusicBox1.ItemHeight = 15;
            this.MusicBox1.Items.AddRange(new object[] {
            "D:\\Csharps\\memo\\Resources\\aa.mp3"});
            this.MusicBox1.Location = new System.Drawing.Point(-2, 160);
            this.MusicBox1.Name = "MusicBox1";
            this.MusicBox1.Size = new System.Drawing.Size(409, 94);
            this.MusicBox1.TabIndex = 18;
            this.MusicBox1.Visible = false;
            this.MusicBox1.SelectedIndexChanged += new System.EventHandler(this.MusicBox1_SelectedIndexChanged);
            this.MusicBox1.DoubleClick += new System.EventHandler(this.MusicBox1_DoubleClick);
            // 
            // Cmusic
            // 
            this.Cmusic.Location = new System.Drawing.Point(97, 116);
            this.Cmusic.Name = "Cmusic";
            this.Cmusic.Size = new System.Drawing.Size(97, 38);
            this.Cmusic.TabIndex = 19;
            this.Cmusic.Text = "选择音乐";
            this.Cmusic.UseVisualStyleBackColor = true;
            this.Cmusic.Click += new System.EventHandler(this.Cmusic_Click);
            // 
            // ClockBox1
            // 
            this.ClockBox1.FormattingEnabled = true;
            this.ClockBox1.ItemHeight = 15;
            this.ClockBox1.Location = new System.Drawing.Point(-2, 160);
            this.ClockBox1.Name = "ClockBox1";
            this.ClockBox1.Size = new System.Drawing.Size(409, 94);
            this.ClockBox1.TabIndex = 20;
            this.ClockBox1.Visible = false;
            this.ClockBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(168, 80);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(239, 25);
            this.Do.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "事件：";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.richTextBox1.Location = new System.Drawing.Point(0, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 272);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(10, 78);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(81, 24);
            this.Save.TabIndex = 24;
            this.Save.Text = "本地保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::memo.Properties.Resources.aa1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 460);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.ClockBox1);
            this.Controls.Add(this.Cmusic);
            this.Controls.Add(this.MusicBox1);
            this.Controls.Add(this.MusicPlayer1);
            this.Controls.Add(this.music);
            this.Controls.Add(this.look);
            this.Controls.Add(this.second);
            this.Controls.Add(this.minuate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放音乐MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停开始sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一首ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一首FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置或更换图片PToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minuate;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.Button look;
        private System.Windows.Forms.Button music;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer1;
        protected System.Windows.Forms.ListBox MusicBox1;
        private System.Windows.Forms.Button Cmusic;
        private System.Windows.Forms.ListBox ClockBox1;
        private System.Windows.Forms.TextBox Do;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Save;
    }
}

