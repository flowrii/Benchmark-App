
namespace Proiect1
{
    partial class FormInstruction
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
            this.instrTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instrTextBox
            // 
            this.instrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrTextBox.Location = new System.Drawing.Point(12, 14);
            this.instrTextBox.Multiline = true;
            this.instrTextBox.Name = "instrTextBox";
            this.instrTextBox.ReadOnly = true;
            this.instrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instrTextBox.Size = new System.Drawing.Size(419, 426);
            this.instrTextBox.TabIndex = 2;
            // 
            // FormInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 455);
            this.Controls.Add(this.instrTextBox);
            this.Name = "FormInstruction";
            this.Text = "FormInstruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox instrTextBox;
    }
}