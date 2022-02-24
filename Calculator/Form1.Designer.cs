namespace Calculator
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
            this.labA = new System.Windows.Forms.Label();
            this.labB = new System.Windows.Forms.Label();
            this.labKq = new System.Windows.Forms.Label();
            this.cong = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labA
            // 
            this.labA.AutoSize = true;
            this.labA.Location = new System.Drawing.Point(32, 40);
            this.labA.Name = "labA";
            this.labA.Size = new System.Drawing.Size(73, 17);
            this.labA.TabIndex = 0;
            this.labA.Text = "Nhap so a";
            // 
            // labB
            // 
            this.labB.AutoSize = true;
            this.labB.Location = new System.Drawing.Point(32, 76);
            this.labB.Name = "labB";
            this.labB.Size = new System.Drawing.Size(73, 17);
            this.labB.TabIndex = 1;
            this.labB.Text = "Nhap so b";
            // 
            // labKq
            // 
            this.labKq.AutoSize = true;
            this.labKq.Location = new System.Drawing.Point(32, 138);
            this.labKq.Name = "labKq";
            this.labKq.Size = new System.Drawing.Size(57, 17);
            this.labKq.TabIndex = 2;
            this.labKq.Text = "Ket qua";
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(100, 196);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(75, 23);
            this.cong.TabIndex = 3;
            this.cong.Text = "Cong";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(111, 37);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(111, 73);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 5;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(111, 138);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(100, 22);
            this.txtKq.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.labKq);
            this.Controls.Add(this.labB);
            this.Controls.Add(this.labA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labA;
        private System.Windows.Forms.Label labB;
        private System.Windows.Forms.Label labKq;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKq;
    }
}

