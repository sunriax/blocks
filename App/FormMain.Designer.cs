
namespace Ragae.Game.Blocks.App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.highscoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.buttonScoreBoard = new System.Windows.Forms.Button();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.groupBoxNext = new System.Windows.Forms.GroupBox();
            this.pictureBoxBrick = new System.Windows.Forms.PictureBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.labelXValue = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelYValue = new System.Windows.Forms.Label();
            this.groupBoxDebug = new System.Windows.Forms.GroupBox();
            this.menuStripMain.SuspendLayout();
            this.groupBoxGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            this.groupBoxNext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxScore.SuspendLayout();
            this.groupBoxDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Click += new System.EventHandler(this.menuStripMain_Click);
            // 
            // gameToolStripMenuItem
            // 
            resources.ApplyResources(this.gameToolStripMenuItem, "gameToolStripMenuItem");
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.toolStripSeparator2,
            this.highscoreToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator4,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Rows;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            // 
            // startToolStripMenuItem
            // 
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Run;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // highscoreToolStripMenuItem
            // 
            resources.ApplyResources(this.highscoreToolStripMenuItem, "highscoreToolStripMenuItem");
            this.highscoreToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.ListView;
            this.highscoreToolStripMenuItem.Name = "highscoreToolStripMenuItem";
            this.highscoreToolStripMenuItem.Click += new System.EventHandler(this.highscoreToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // quitToolStripMenuItem
            // 
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Exit;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.handlingToolStripMenuItem,
            this.soundToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.toolStripSeparator5,
            this.gridToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // handlingToolStripMenuItem
            // 
            resources.ApplyResources(this.handlingToolStripMenuItem, "handlingToolStripMenuItem");
            this.handlingToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Handling;
            this.handlingToolStripMenuItem.Name = "handlingToolStripMenuItem";
            this.handlingToolStripMenuItem.Click += new System.EventHandler(this.handlingToolStripMenuItem_Click);
            // 
            // soundToolStripMenuItem
            // 
            resources.ApplyResources(this.soundToolStripMenuItem, "soundToolStripMenuItem");
            this.soundToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Sound;
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Click += new System.EventHandler(this.soundToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            resources.ApplyResources(this.colorToolStripMenuItem, "colorToolStripMenuItem");
            this.colorToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Color;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // gridToolStripMenuItem
            // 
            resources.ApplyResources(this.gridToolStripMenuItem, "gridToolStripMenuItem");
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.CheckedChanged += new System.EventHandler(this.gridToolStripMenuItem_CheckedChanged);
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.toolStripSeparator1,
            this.updateToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Hot;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Flag;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // updateToolStripMenuItem
            // 
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Update;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            resources.ApplyResources(this.versionToolStripMenuItem, "versionToolStripMenuItem");
            this.versionToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Version;
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            resources.ApplyResources(this.licenseToolStripMenuItem, "licenseToolStripMenuItem");
            this.licenseToolStripMenuItem.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Contract;
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // groupBoxGame
            // 
            resources.ApplyResources(this.groupBoxGame, "groupBoxGame");
            this.groupBoxGame.Controls.Add(this.buttonScoreBoard);
            this.groupBoxGame.Controls.Add(this.labelGameOver);
            this.groupBoxGame.Controls.Add(this.buttonPause);
            this.groupBoxGame.Controls.Add(this.buttonPlay);
            this.groupBoxGame.Controls.Add(this.pictureBoxGame);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.TabStop = false;
            // 
            // buttonScoreBoard
            // 
            resources.ApplyResources(this.buttonScoreBoard, "buttonScoreBoard");
            this.buttonScoreBoard.Name = "buttonScoreBoard";
            this.buttonScoreBoard.UseVisualStyleBackColor = true;
            this.buttonScoreBoard.Click += new System.EventHandler(this.buttonScoreBoard_Click);
            // 
            // labelGameOver
            // 
            resources.ApplyResources(this.labelGameOver, "labelGameOver");
            this.labelGameOver.BackColor = System.Drawing.Color.Red;
            this.labelGameOver.Name = "labelGameOver";
            // 
            // buttonPause
            // 
            resources.ApplyResources(this.buttonPause, "buttonPause");
            this.buttonPause.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Pause;
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            resources.ApplyResources(this.buttonPlay, "buttonPlay");
            this.buttonPlay.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Run;
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBoxGame
            // 
            resources.ApplyResources(this.pictureBoxGame, "pictureBoxGame");
            this.pictureBoxGame.BackColor = System.Drawing.Color.White;
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.TabStop = false;
            this.pictureBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGame_Paint);
            // 
            // groupBoxNext
            // 
            resources.ApplyResources(this.groupBoxNext, "groupBoxNext");
            this.groupBoxNext.Controls.Add(this.pictureBoxBrick);
            this.groupBoxNext.Name = "groupBoxNext";
            this.groupBoxNext.TabStop = false;
            // 
            // pictureBoxBrick
            // 
            resources.ApplyResources(this.pictureBoxBrick, "pictureBoxBrick");
            this.pictureBoxBrick.Name = "pictureBoxBrick";
            this.pictureBoxBrick.TabStop = false;
            this.pictureBoxBrick.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBrick_Paint);
            // 
            // groupBoxSettings
            // 
            resources.ApplyResources(this.groupBoxSettings, "groupBoxSettings");
            this.groupBoxSettings.Controls.Add(this.textBoxPlayer);
            this.groupBoxSettings.Controls.Add(this.checkBoxSound);
            this.groupBoxSettings.Controls.Add(this.comboBoxLevel);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.TabStop = false;
            // 
            // textBoxPlayer
            // 
            resources.ApplyResources(this.textBoxPlayer, "textBoxPlayer");
            this.textBoxPlayer.Name = "textBoxPlayer";
            // 
            // checkBoxSound
            // 
            resources.ApplyResources(this.checkBoxSound, "checkBoxSound");
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            // 
            // comboBoxLevel
            // 
            resources.ApplyResources(this.comboBoxLevel, "comboBoxLevel");
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            resources.GetString("comboBoxLevel.Items"),
            resources.GetString("comboBoxLevel.Items1"),
            resources.GetString("comboBoxLevel.Items2"),
            resources.GetString("comboBoxLevel.Items3"),
            resources.GetString("comboBoxLevel.Items4"),
            resources.GetString("comboBoxLevel.Items5"),
            resources.GetString("comboBoxLevel.Items6"),
            resources.GetString("comboBoxLevel.Items7"),
            resources.GetString("comboBoxLevel.Items8"),
            resources.GetString("comboBoxLevel.Items9")});
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // groupBoxScore
            // 
            resources.ApplyResources(this.groupBoxScore, "groupBoxScore");
            this.groupBoxScore.Controls.Add(this.labelScore);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.TabStop = false;
            // 
            // labelScore
            // 
            resources.ApplyResources(this.labelScore, "labelScore");
            this.labelScore.Name = "labelScore";
            // 
            // linkLabelGithub
            // 
            resources.ApplyResources(this.linkLabelGithub, "linkLabelGithub");
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // labelXValue
            // 
            resources.ApplyResources(this.labelXValue, "labelXValue");
            this.labelXValue.Name = "labelXValue";
            // 
            // labelY
            // 
            resources.ApplyResources(this.labelY, "labelY");
            this.labelY.Name = "labelY";
            // 
            // labelX
            // 
            resources.ApplyResources(this.labelX, "labelX");
            this.labelX.Name = "labelX";
            // 
            // labelYValue
            // 
            resources.ApplyResources(this.labelYValue, "labelYValue");
            this.labelYValue.Name = "labelYValue";
            // 
            // groupBoxDebug
            // 
            resources.ApplyResources(this.groupBoxDebug, "groupBoxDebug");
            this.groupBoxDebug.Controls.Add(this.labelYValue);
            this.groupBoxDebug.Controls.Add(this.labelX);
            this.groupBoxDebug.Controls.Add(this.labelY);
            this.groupBoxDebug.Controls.Add(this.labelXValue);
            this.groupBoxDebug.Name = "groupBoxDebug";
            this.groupBoxDebug.TabStop = false;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDebug);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.groupBoxScore);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxGame);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.groupBoxNext);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Deactivate += new System.EventHandler(this.FormMain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            this.groupBoxNext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxDebug.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.GroupBox groupBoxNext;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxPlayer;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem highscoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.PictureBox pictureBoxBrick;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label labelXValue;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelYValue;
        private System.Windows.Forms.GroupBox groupBoxDebug;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button buttonScoreBoard;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
    }
}

