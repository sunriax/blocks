
namespace Ragae.Game.Blocks.App
{
    partial class FormScoreBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScoreBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewBoard = new System.Windows.Forms.DataGridView();
            this.groupBoxTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTop
            // 
            resources.ApplyResources(this.groupBoxTop, "groupBoxTop");
            this.groupBoxTop.Controls.Add(this.buttonClear);
            this.groupBoxTop.Controls.Add(this.dataGridViewBoard);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.TabStop = false;
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewBoard
            // 
            resources.ApplyResources(this.dataGridViewBoard, "dataGridViewBoard");
            this.dataGridViewBoard.AllowUserToAddRows = false;
            this.dataGridViewBoard.AllowUserToDeleteRows = false;
            this.dataGridViewBoard.AllowUserToResizeRows = false;
            this.dataGridViewBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBoard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBoard.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBoard.MultiSelect = false;
            this.dataGridViewBoard.Name = "dataGridViewBoard";
            this.dataGridViewBoard.ReadOnly = true;
            this.dataGridViewBoard.RowTemplate.Height = 25;
            // 
            // FormScoreBoard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTop);
            this.Name = "FormScoreBoard";
            this.groupBoxTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.DataGridView dataGridViewBoard;
        private System.Windows.Forms.Button buttonClear;
    }
}