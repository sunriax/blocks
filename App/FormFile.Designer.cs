
namespace Ragae.Game.Blocks.App
{
    partial class FormFile
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
            this.richTextBoxVersion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxVersion
            // 
            this.richTextBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxVersion.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxVersion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxVersion.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxVersion.Name = "richTextBoxVersion";
            this.richTextBoxVersion.ReadOnly = true;
            this.richTextBoxVersion.Size = new System.Drawing.Size(359, 136);
            this.richTextBoxVersion.TabIndex = 1;
            this.richTextBoxVersion.Text = "";
            this.richTextBoxVersion.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxVersion_LinkClicked);
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 157);
            this.Controls.Add(this.richTextBoxVersion);
            this.Name = "FormFile";
            this.Text = "FormFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxVersion;
    }
}