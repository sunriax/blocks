
namespace RaGae.Game.Blocks.App
{
    partial class FormOpenGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpenGame));
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.listBoxGame = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBoxGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGame
            // 
            resources.ApplyResources(this.groupBoxGame, "groupBoxGame");
            this.groupBoxGame.Controls.Add(this.listBoxGame);
            this.groupBoxGame.Controls.Add(this.buttonRemove);
            this.groupBoxGame.Controls.Add(this.buttonOpen);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.TabStop = false;
            // 
            // listBoxGame
            // 
            resources.ApplyResources(this.listBoxGame, "listBoxGame");
            this.listBoxGame.FormattingEnabled = true;
            this.listBoxGame.Name = "listBoxGame";
            // 
            // buttonRemove
            // 
            resources.ApplyResources(this.buttonRemove, "buttonRemove");
            this.buttonRemove.Image = global::RaGae.Game.Blocks.App.Properties.ImageResource.Remove;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonOpen
            // 
            resources.ApplyResources(this.buttonOpen, "buttonOpen");
            this.buttonOpen.Image = global::RaGae.Game.Blocks.App.Properties.ImageResource.Open;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // FormOpenGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxGame);
            this.Name = "FormOpenGame";
            this.Load += new System.EventHandler(this.FormOpenGame_Load);
            this.groupBoxGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ListBox listBoxGame;
    }
}