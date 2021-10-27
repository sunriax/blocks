
namespace Ragae.Game.Blocks.App
{
    partial class FormColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColor));
            this.groupBoxField = new System.Windows.Forms.GroupBox();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonGrid = new System.Windows.Forms.Button();
            this.pictureBoxField = new System.Windows.Forms.PictureBox();
            this.groupBoxBrick = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxBrick = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxBrick = new System.Windows.Forms.PictureBox();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.groupBoxField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.groupBoxBrick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxField
            // 
            resources.ApplyResources(this.groupBoxField, "groupBoxField");
            this.groupBoxField.Controls.Add(this.buttonBackground);
            this.groupBoxField.Controls.Add(this.buttonGrid);
            this.groupBoxField.Controls.Add(this.pictureBoxField);
            this.groupBoxField.Name = "groupBoxField";
            this.groupBoxField.TabStop = false;
            // 
            // buttonBackground
            // 
            resources.ApplyResources(this.buttonBackground, "buttonBackground");
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonField_Click);
            // 
            // buttonGrid
            // 
            resources.ApplyResources(this.buttonGrid, "buttonGrid");
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.UseVisualStyleBackColor = true;
            this.buttonGrid.Click += new System.EventHandler(this.buttonField_Click);
            // 
            // pictureBoxField
            // 
            resources.ApplyResources(this.pictureBoxField, "pictureBoxField");
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.TabStop = false;
            // 
            // groupBoxBrick
            // 
            resources.ApplyResources(this.groupBoxBrick, "groupBoxBrick");
            this.groupBoxBrick.Controls.Add(this.buttonRemove);
            this.groupBoxBrick.Controls.Add(this.listBoxBrick);
            this.groupBoxBrick.Controls.Add(this.buttonAdd);
            this.groupBoxBrick.Controls.Add(this.pictureBoxBrick);
            this.groupBoxBrick.Name = "groupBoxBrick";
            this.groupBoxBrick.TabStop = false;
            // 
            // buttonRemove
            // 
            resources.ApplyResources(this.buttonRemove, "buttonRemove");
            this.buttonRemove.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Remove;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBoxBrick
            // 
            resources.ApplyResources(this.listBoxBrick, "listBoxBrick");
            this.listBoxBrick.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxBrick.FormattingEnabled = true;
            this.listBoxBrick.Name = "listBoxBrick";
            this.listBoxBrick.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxBrick_DrawItem);
            this.listBoxBrick.SelectedIndexChanged += new System.EventHandler(this.listBoxBrick_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Image = global::Ragae.Game.Blocks.App.Properties.ImageResource.Add;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBoxBrick
            // 
            resources.ApplyResources(this.pictureBoxBrick, "pictureBoxBrick");
            this.pictureBoxBrick.Name = "pictureBoxBrick";
            this.pictureBoxBrick.TabStop = false;
            this.pictureBoxBrick.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBrick_Paint);
            // 
            // buttonDefault
            // 
            resources.ApplyResources(this.buttonDefault, "buttonDefault");
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // FormColor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.groupBoxBrick);
            this.Controls.Add(this.groupBoxField);
            this.Name = "FormColor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormColor_FormClosing);
            this.Load += new System.EventHandler(this.FormColor_Load);
            this.groupBoxField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.groupBoxBrick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxField;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonGrid;
        private System.Windows.Forms.PictureBox pictureBoxField;
        private System.Windows.Forms.GroupBox groupBoxBrick;
        private System.Windows.Forms.ListBox listBoxBrick;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxBrick;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonDefault;
    }
}