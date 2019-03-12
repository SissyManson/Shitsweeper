namespace Mineshit
{
    partial class DaGAYme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaGAYme));
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblFlags = new System.Windows.Forms.Label();
            this.tbSeconds = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbWidth
            // 
            this.tbWidth.BackColor = System.Drawing.SystemColors.Control;
            this.tbWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWidth.Location = new System.Drawing.Point(439, 92);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(89, 27);
            this.tbWidth.TabIndex = 3;
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHeight
            // 
            this.tbHeight.BackColor = System.Drawing.SystemColors.Control;
            this.tbHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHeight.Location = new System.Drawing.Point(439, 44);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(89, 27);
            this.tbHeight.TabIndex = 2;
            this.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(247, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 28);
            this.label3.TabIndex = 44;
            this.label3.Text = ":";
            // 
            // tbMinutes
            // 
            this.tbMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMinutes.Enabled = false;
            this.tbMinutes.Location = new System.Drawing.Point(196, 80);
            this.tbMinutes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(41, 27);
            this.tbMinutes.TabIndex = 43;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(738, 91);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(277, 36);
            this.btnPlay.TabIndex = 42;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbDifficulty.Location = new System.Drawing.Point(849, 47);
            this.cbDifficulty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(166, 35);
            this.cbDifficulty.TabIndex = 41;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Location = new System.Drawing.Point(358, 91);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(71, 28);
            this.lblWidth.TabIndex = 40;
            this.lblWidth.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fugaz One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "min 5 - max 40";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficulty.Location = new System.Drawing.Point(733, 46);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(106, 28);
            this.lblDifficulty.TabIndex = 38;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Location = new System.Drawing.Point(355, 43);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(74, 28);
            this.lblHeight.TabIndex = 37;
            this.lblHeight.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fugaz One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "min 5 - max 25";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Location = new System.Drawing.Point(21, 43);
            this.lblScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 28);
            this.lblScore.TabIndex = 35;
            this.lblScore.Text = "Score";
            // 
            // lblFlags
            // 
            this.lblFlags.AutoSize = true;
            this.lblFlags.BackColor = System.Drawing.Color.Transparent;
            this.lblFlags.Location = new System.Drawing.Point(21, 91);
            this.lblFlags.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(61, 28);
            this.lblFlags.TabIndex = 34;
            this.lblFlags.Text = "Flags";
            // 
            // tbSeconds
            // 
            this.tbSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSeconds.Enabled = false;
            this.tbSeconds.Location = new System.Drawing.Point(275, 80);
            this.tbSeconds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSeconds.Name = "tbSeconds";
            this.tbSeconds.Size = new System.Drawing.Size(41, 27);
            this.tbSeconds.TabIndex = 33;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(229, 47);
            this.lblTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 28);
            this.lblTime.TabIndex = 32;
            this.lblTime.Text = "Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1082, 30);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.resetToolStripMenuItem.Text = "Restart";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option1ToolStripMenuItem,
            this.option2ToolStripMenuItem,
            this.muteToolStripMenuItem});
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.musicToolStripMenuItem.Text = "Music";
            // 
            // option1ToolStripMenuItem
            // 
            this.option1ToolStripMenuItem.Name = "option1ToolStripMenuItem";
            this.option1ToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.option1ToolStripMenuItem.Text = "Option 1";
            this.option1ToolStripMenuItem.ToolTipText = "Clarx - Bones";
            this.option1ToolStripMenuItem.Click += new System.EventHandler(this.option1ToolStripMenuItem_Click);
            // 
            // option2ToolStripMenuItem
            // 
            this.option2ToolStripMenuItem.Name = "option2ToolStripMenuItem";
            this.option2ToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.option2ToolStripMenuItem.Text = "Option 2";
            this.option2ToolStripMenuItem.ToolTipText = "Marin Hoxha - Endless";
            this.option2ToolStripMenuItem.Click += new System.EventHandler(this.option2ToolStripMenuItem_Click);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.muteToolStripMenuItem.Text = "Mute";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.muteToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purpleToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "Press F1 for Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.muteMusicToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 76);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.aboutToolStripMenuItem.Text = "About me";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // muteMusicToolStripMenuItem
            // 
            this.muteMusicToolStripMenuItem.Name = "muteMusicToolStripMenuItem";
            this.muteMusicToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.muteMusicToolStripMenuItem.Text = "Mute music";
            this.muteMusicToolStripMenuItem.Click += new System.EventHandler(this.muteMusicToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.ForeColor = System.Drawing.Color.BlueViolet;
            this.progressBar.Location = new System.Drawing.Point(0, 730);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1082, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // DaGAYme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMinutes);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblFlags);
            this.Controls.Add(this.tbSeconds);
            this.Controls.Add(this.lblTime);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Fugaz One", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "DaGAYme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DaGAYme_FormClosing);
            this.Load += new System.EventHandler(this.DaGAYme_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFlags;
        private System.Windows.Forms.TextBox tbSeconds;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem muteMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
    }
}

