
namespace Blocks.Forms
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxBlocks = new System.Windows.Forms.GroupBox();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.groupBoxRanking = new System.Windows.Forms.GroupBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.pictureBoxBlocks = new System.Windows.Forms.PictureBox();
            this.timerInterval = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.groupBoxBlocks.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlocks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(622, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankingToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.rankingToolStripMenuItem.Text = "Ranking";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem,
            this.toolStripSeparator2,
            this.updateToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // groupBoxBlocks
            // 
            this.groupBoxBlocks.Controls.Add(this.linkLabelGithub);
            this.groupBoxBlocks.Controls.Add(this.groupBoxRanking);
            this.groupBoxBlocks.Controls.Add(this.groupBoxSettings);
            this.groupBoxBlocks.Controls.Add(this.pictureBoxBlocks);
            this.groupBoxBlocks.Location = new System.Drawing.Point(12, 31);
            this.groupBoxBlocks.Name = "groupBoxBlocks";
            this.groupBoxBlocks.Size = new System.Drawing.Size(598, 390);
            this.groupBoxBlocks.TabIndex = 1;
            this.groupBoxBlocks.TabStop = false;
            this.groupBoxBlocks.Text = "Blocks";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(456, 357);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(136, 20);
            this.linkLabelGithub.TabIndex = 4;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "github.com/sunriax";
            // 
            // groupBoxRanking
            // 
            this.groupBoxRanking.Location = new System.Drawing.Point(322, 166);
            this.groupBoxRanking.Name = "groupBoxRanking";
            this.groupBoxRanking.Size = new System.Drawing.Size(270, 133);
            this.groupBoxRanking.TabIndex = 3;
            this.groupBoxRanking.TabStop = false;
            this.groupBoxRanking.Text = "Ranking";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.buttonStart);
            this.groupBoxSettings.Controls.Add(this.checkBoxSound);
            this.groupBoxSettings.Controls.Add(this.comboBoxLevel);
            this.groupBoxSettings.Location = new System.Drawing.Point(322, 27);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(270, 133);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(7, 91);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(94, 29);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Location = new System.Drawing.Point(7, 61);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(73, 24);
            this.checkBoxSound.TabIndex = 1;
            this.checkBoxSound.Text = "Sound";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Level 9"});
            this.comboBoxLevel.Location = new System.Drawing.Point(7, 27);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(150, 28);
            this.comboBoxLevel.TabIndex = 0;
            // 
            // pictureBoxBlocks
            // 
            this.pictureBoxBlocks.BackColor = System.Drawing.Color.White;
            this.pictureBoxBlocks.Enabled = false;
            this.pictureBoxBlocks.Location = new System.Drawing.Point(7, 27);
            this.pictureBoxBlocks.Name = "pictureBoxBlocks";
            this.pictureBoxBlocks.Size = new System.Drawing.Size(300, 350);
            this.pictureBoxBlocks.TabIndex = 0;
            this.pictureBoxBlocks.TabStop = false;
            this.pictureBoxBlocks.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBlocks_Paint);
            // 
            // timerInterval
            // 
            this.timerInterval.Interval = 1000;
            this.timerInterval.Tick += new System.EventHandler(this.timerInterval_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.groupBoxBlocks);
            this.Controls.Add(this.menuStripMain);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Blocks";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxBlocks.ResumeLayout(false);
            this.groupBoxBlocks.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxBlocks;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.GroupBox groupBoxRanking;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.PictureBox pictureBoxBlocks;
        private System.Windows.Forms.Timer timerInterval;
    }
}

