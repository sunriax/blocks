
namespace RaGae.Game.Blocks.App
{
    partial class FormHandling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHandling));
            this.groupBoxKeys = new System.Windows.Forms.GroupBox();
            this.buttonFocus = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.groupBoxPause = new System.Windows.Forms.GroupBox();
            this.labelPauseOptional = new System.Windows.Forms.Label();
            this.labelPauseStandard = new System.Windows.Forms.Label();
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.textBoxPause = new System.Windows.Forms.TextBox();
            this.groupBoxRotate = new System.Windows.Forms.GroupBox();
            this.labelRotateOptional = new System.Windows.Forms.Label();
            this.labelRotateStandard = new System.Windows.Forms.Label();
            this.pictureBoxRotateOptional = new System.Windows.Forms.PictureBox();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.labelRightOptional = new System.Windows.Forms.Label();
            this.labelRightStandard = new System.Windows.Forms.Label();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.labelLeftOptional = new System.Windows.Forms.Label();
            this.labelLeftStandard = new System.Windows.Forms.Label();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.groupBoxDown = new System.Windows.Forms.GroupBox();
            this.labelDownOptional = new System.Windows.Forms.Label();
            this.labelDownStandard = new System.Windows.Forms.Label();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.textBoxDown = new System.Windows.Forms.TextBox();
            this.pictureBoxBrick = new System.Windows.Forms.PictureBox();
            this.groupBoxKeys.SuspendLayout();
            this.groupBoxPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            this.groupBoxRotate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotateOptional)).BeginInit();
            this.groupBoxRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            this.groupBoxLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            this.groupBoxDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKeys
            // 
            resources.ApplyResources(this.groupBoxKeys, "groupBoxKeys");
            this.groupBoxKeys.Controls.Add(this.buttonFocus);
            this.groupBoxKeys.Controls.Add(this.buttonDefault);
            this.groupBoxKeys.Controls.Add(this.groupBoxPause);
            this.groupBoxKeys.Controls.Add(this.groupBoxRotate);
            this.groupBoxKeys.Controls.Add(this.groupBoxRight);
            this.groupBoxKeys.Controls.Add(this.groupBoxLeft);
            this.groupBoxKeys.Controls.Add(this.groupBoxDown);
            this.groupBoxKeys.Controls.Add(this.pictureBoxBrick);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.TabStop = false;
            // 
            // buttonFocus
            // 
            resources.ApplyResources(this.buttonFocus, "buttonFocus");
            this.buttonFocus.Image = global::RaGae.Game.Blocks.App.Properties.ImageResource.Wizard;
            this.buttonFocus.Name = "buttonFocus";
            this.buttonFocus.UseVisualStyleBackColor = true;
            // 
            // buttonDefault
            // 
            resources.ApplyResources(this.buttonDefault, "buttonDefault");
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // groupBoxPause
            // 
            resources.ApplyResources(this.groupBoxPause, "groupBoxPause");
            this.groupBoxPause.Controls.Add(this.labelPauseOptional);
            this.groupBoxPause.Controls.Add(this.labelPauseStandard);
            this.groupBoxPause.Controls.Add(this.pictureBoxPause);
            this.groupBoxPause.Controls.Add(this.textBoxPause);
            this.groupBoxPause.Name = "groupBoxPause";
            this.groupBoxPause.TabStop = false;
            // 
            // labelPauseOptional
            // 
            resources.ApplyResources(this.labelPauseOptional, "labelPauseOptional");
            this.labelPauseOptional.Name = "labelPauseOptional";
            // 
            // labelPauseStandard
            // 
            resources.ApplyResources(this.labelPauseStandard, "labelPauseStandard");
            this.labelPauseStandard.Name = "labelPauseStandard";
            // 
            // pictureBoxPause
            // 
            resources.ApplyResources(this.pictureBoxPause, "pictureBoxPause");
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.TabStop = false;
            this.pictureBoxPause.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPauseStandard_Paint);
            // 
            // textBoxPause
            // 
            resources.ApplyResources(this.textBoxPause, "textBoxPause");
            this.textBoxPause.Name = "textBoxPause";
            this.textBoxPause.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // groupBoxRotate
            // 
            resources.ApplyResources(this.groupBoxRotate, "groupBoxRotate");
            this.groupBoxRotate.Controls.Add(this.labelRotateOptional);
            this.groupBoxRotate.Controls.Add(this.labelRotateStandard);
            this.groupBoxRotate.Controls.Add(this.pictureBoxRotateOptional);
            this.groupBoxRotate.Controls.Add(this.textBoxRotate);
            this.groupBoxRotate.Name = "groupBoxRotate";
            this.groupBoxRotate.TabStop = false;
            // 
            // labelRotateOptional
            // 
            resources.ApplyResources(this.labelRotateOptional, "labelRotateOptional");
            this.labelRotateOptional.Name = "labelRotateOptional";
            // 
            // labelRotateStandard
            // 
            resources.ApplyResources(this.labelRotateStandard, "labelRotateStandard");
            this.labelRotateStandard.Name = "labelRotateStandard";
            // 
            // pictureBoxRotateOptional
            // 
            resources.ApplyResources(this.pictureBoxRotateOptional, "pictureBoxRotateOptional");
            this.pictureBoxRotateOptional.Name = "pictureBoxRotateOptional";
            this.pictureBoxRotateOptional.TabStop = false;
            this.pictureBoxRotateOptional.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxRotateOptional_Paint);
            // 
            // textBoxRotate
            // 
            resources.ApplyResources(this.textBoxRotate, "textBoxRotate");
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // groupBoxRight
            // 
            resources.ApplyResources(this.groupBoxRight, "groupBoxRight");
            this.groupBoxRight.Controls.Add(this.labelRightOptional);
            this.groupBoxRight.Controls.Add(this.labelRightStandard);
            this.groupBoxRight.Controls.Add(this.pictureBoxRight);
            this.groupBoxRight.Controls.Add(this.textBoxRight);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.TabStop = false;
            // 
            // labelRightOptional
            // 
            resources.ApplyResources(this.labelRightOptional, "labelRightOptional");
            this.labelRightOptional.Name = "labelRightOptional";
            // 
            // labelRightStandard
            // 
            resources.ApplyResources(this.labelRightStandard, "labelRightStandard");
            this.labelRightStandard.Name = "labelRightStandard";
            // 
            // pictureBoxRight
            // 
            resources.ApplyResources(this.pictureBoxRight, "pictureBoxRight");
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.TabStop = false;
            // 
            // textBoxRight
            // 
            resources.ApplyResources(this.textBoxRight, "textBoxRight");
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // groupBoxLeft
            // 
            resources.ApplyResources(this.groupBoxLeft, "groupBoxLeft");
            this.groupBoxLeft.Controls.Add(this.labelLeftOptional);
            this.groupBoxLeft.Controls.Add(this.labelLeftStandard);
            this.groupBoxLeft.Controls.Add(this.pictureBoxLeft);
            this.groupBoxLeft.Controls.Add(this.textBoxLeft);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.TabStop = false;
            // 
            // labelLeftOptional
            // 
            resources.ApplyResources(this.labelLeftOptional, "labelLeftOptional");
            this.labelLeftOptional.Name = "labelLeftOptional";
            // 
            // labelLeftStandard
            // 
            resources.ApplyResources(this.labelLeftStandard, "labelLeftStandard");
            this.labelLeftStandard.Name = "labelLeftStandard";
            // 
            // pictureBoxLeft
            // 
            resources.ApplyResources(this.pictureBoxLeft, "pictureBoxLeft");
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.TabStop = false;
            // 
            // textBoxLeft
            // 
            resources.ApplyResources(this.textBoxLeft, "textBoxLeft");
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // groupBoxDown
            // 
            resources.ApplyResources(this.groupBoxDown, "groupBoxDown");
            this.groupBoxDown.Controls.Add(this.labelDownOptional);
            this.groupBoxDown.Controls.Add(this.labelDownStandard);
            this.groupBoxDown.Controls.Add(this.pictureBoxDown);
            this.groupBoxDown.Controls.Add(this.textBoxDown);
            this.groupBoxDown.Name = "groupBoxDown";
            this.groupBoxDown.TabStop = false;
            // 
            // labelDownOptional
            // 
            resources.ApplyResources(this.labelDownOptional, "labelDownOptional");
            this.labelDownOptional.Name = "labelDownOptional";
            // 
            // labelDownStandard
            // 
            resources.ApplyResources(this.labelDownStandard, "labelDownStandard");
            this.labelDownStandard.Name = "labelDownStandard";
            // 
            // pictureBoxDown
            // 
            resources.ApplyResources(this.pictureBoxDown, "pictureBoxDown");
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.TabStop = false;
            // 
            // textBoxDown
            // 
            resources.ApplyResources(this.textBoxDown, "textBoxDown");
            this.textBoxDown.Name = "textBoxDown";
            this.textBoxDown.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // pictureBoxBrick
            // 
            resources.ApplyResources(this.pictureBoxBrick, "pictureBoxBrick");
            this.pictureBoxBrick.BackColor = System.Drawing.Color.White;
            this.pictureBoxBrick.Name = "pictureBoxBrick";
            this.pictureBoxBrick.TabStop = false;
            this.pictureBoxBrick.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBrick_Paint);
            // 
            // FormHandling
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxKeys);
            this.KeyPreview = true;
            this.Name = "FormHandling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHandling_FormClosing);
            this.Load += new System.EventHandler(this.FormHandling_Load);
            this.Click += new System.EventHandler(this.FormHandling_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHandling_KeyDown);
            this.groupBoxKeys.ResumeLayout(false);
            this.groupBoxPause.ResumeLayout(false);
            this.groupBoxPause.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            this.groupBoxRotate.ResumeLayout(false);
            this.groupBoxRotate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotateOptional)).EndInit();
            this.groupBoxRight.ResumeLayout(false);
            this.groupBoxRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            this.groupBoxDown.ResumeLayout(false);
            this.groupBoxDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKeys;
        private System.Windows.Forms.GroupBox groupBoxDown;
        private System.Windows.Forms.Label labelDownOptional;
        private System.Windows.Forms.Label labelDownStandard;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.TextBox textBoxDown;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.Label labelRightOptional;
        private System.Windows.Forms.Label labelRightStandard;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.Label labelLeftOptional;
        private System.Windows.Forms.Label labelLeftStandard;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.GroupBox groupBoxRotate;
        private System.Windows.Forms.Label labelRotateOptional;
        private System.Windows.Forms.Label labelRotateStandard;
        private System.Windows.Forms.PictureBox pictureBoxRotateOptional;
        private System.Windows.Forms.TextBox textBoxRotate;
        private System.Windows.Forms.PictureBox pictureBoxBrick;
        private System.Windows.Forms.GroupBox groupBoxPause;
        private System.Windows.Forms.Label labelPauseOptional;
        private System.Windows.Forms.Label labelPauseStandard;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.TextBox textBoxPause;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonFocus;
    }
}