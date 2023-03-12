
namespace Proiect1
{
    partial class FormDisk
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
            this.diskTextBox = new System.Windows.Forms.TextBox();
            this.fileSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // diskTextBox
            // 
            this.diskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskTextBox.Location = new System.Drawing.Point(12, 62);
            this.diskTextBox.Multiline = true;
            this.diskTextBox.Name = "diskTextBox";
            this.diskTextBox.ReadOnly = true;
            this.diskTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.diskTextBox.Size = new System.Drawing.Size(419, 426);
            this.diskTextBox.TabIndex = 1;
            // 
            // fileSizeComboBox
            // 
            this.fileSizeComboBox.FormattingEnabled = true;
            this.fileSizeComboBox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "128",
            "256",
            "512",
            "1024"});
            this.fileSizeComboBox.Location = new System.Drawing.Point(144, 22);
            this.fileSizeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileSizeComboBox.Name = "fileSizeComboBox";
            this.fileSizeComboBox.Size = new System.Drawing.Size(106, 21);
            this.fileSizeComboBox.TabIndex = 3;
            this.fileSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fileSizeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select file size (MB):";
            // 
            // FormDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileSizeComboBox);
            this.Controls.Add(this.diskTextBox);
            this.Name = "FormDisk";
            this.Text = "FormDisk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diskTextBox;
        private System.Windows.Forms.ComboBox fileSizeComboBox;
        private System.Windows.Forms.Label label1;
    }
}