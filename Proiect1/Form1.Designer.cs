
namespace Proiect1
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.diskBtn = new System.Windows.Forms.Button();
            this.cpuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(419, 426);
            this.textBox1.TabIndex = 0;
            // 
            // diskBtn
            // 
            this.diskBtn.Location = new System.Drawing.Point(12, 444);
            this.diskBtn.Name = "diskBtn";
            this.diskBtn.Size = new System.Drawing.Size(111, 23);
            this.diskBtn.TabIndex = 1;
            this.diskBtn.Text = "Test disk";
            this.diskBtn.UseVisualStyleBackColor = true;
            this.diskBtn.Click += new System.EventHandler(this.diskBtn_Click);
            // 
            // cpuBtn
            // 
            this.cpuBtn.Location = new System.Drawing.Point(320, 446);
            this.cpuBtn.Name = "cpuBtn";
            this.cpuBtn.Size = new System.Drawing.Size(111, 23);
            this.cpuBtn.TabIndex = 2;
            this.cpuBtn.Text = "Test CPU";
            this.cpuBtn.UseVisualStyleBackColor = true;
            this.cpuBtn.Click += new System.EventHandler(this.cpuBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 481);
            this.Controls.Add(this.cpuBtn);
            this.Controls.Add(this.diskBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button diskBtn;
        private System.Windows.Forms.Button cpuBtn;
    }
}

