
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
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
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
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(544, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.rankingToolStripMenuItem.Text = "Ranking";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // groupBoxBlocks
            // 
            this.groupBoxBlocks.Controls.Add(this.linkLabelGithub);
            this.groupBoxBlocks.Controls.Add(this.groupBoxRanking);
            this.groupBoxBlocks.Controls.Add(this.groupBoxSettings);
            this.groupBoxBlocks.Controls.Add(this.pictureBoxBlocks);
            this.groupBoxBlocks.Location = new System.Drawing.Point(10, 23);
            this.groupBoxBlocks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBlocks.Name = "groupBoxBlocks";
            this.groupBoxBlocks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBlocks.Size = new System.Drawing.Size(523, 292);
            this.groupBoxBlocks.TabIndex = 1;
            this.groupBoxBlocks.TabStop = false;
            this.groupBoxBlocks.Text = "Blocks";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(399, 268);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(112, 15);
            this.linkLabelGithub.TabIndex = 4;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "github.com/sunriax";
            // 
            // groupBoxRanking
            // 
            this.groupBoxRanking.Location = new System.Drawing.Point(281, 148);
            this.groupBoxRanking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRanking.Name = "groupBoxRanking";
            this.groupBoxRanking.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRanking.Size = new System.Drawing.Size(236, 100);
            this.groupBoxRanking.TabIndex = 3;
            this.groupBoxRanking.TabStop = false;
            this.groupBoxRanking.Text = "Next";
            this.groupBoxRanking.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxRanking_Paint);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.checkBoxGrid);
            this.groupBoxSettings.Controls.Add(this.buttonStart);
            this.groupBoxSettings.Controls.Add(this.checkBoxSound);
            this.groupBoxSettings.Controls.Add(this.comboBoxLevel);
            this.groupBoxSettings.Location = new System.Drawing.Point(282, 20);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSettings.Size = new System.Drawing.Size(236, 124);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Location = new System.Drawing.Point(6, 69);
            this.checkBoxGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(48, 19);
            this.checkBoxGrid.TabIndex = 3;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 92);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(82, 22);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Location = new System.Drawing.Point(6, 46);
            this.checkBoxSound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(60, 19);
            this.checkBoxSound.TabIndex = 1;
            this.checkBoxSound.Text = "Sound";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            this.checkBoxSound.CheckedChanged += new System.EventHandler(this.checkBoxSound_CheckedChanged);
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
            this.comboBoxLevel.Location = new System.Drawing.Point(6, 20);
            this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(132, 23);
            this.comboBoxLevel.TabIndex = 0;
            // 
            // pictureBoxBlocks
            // 
            this.pictureBoxBlocks.BackColor = System.Drawing.Color.White;
            this.pictureBoxBlocks.Enabled = false;
            this.pictureBoxBlocks.Location = new System.Drawing.Point(6, 20);
            this.pictureBoxBlocks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBlocks.Name = "pictureBoxBlocks";
            this.pictureBoxBlocks.Size = new System.Drawing.Size(262, 262);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 325);
            this.Controls.Add(this.groupBoxBlocks);
            this.Controls.Add(this.menuStripMain);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckBox checkBoxGrid;
    }
}

