﻿namespace Login
{
    partial class Penatly
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPenatly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(14, 10);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(91, 13);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "Enter Book ISBN:";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Location = new System.Drawing.Point(14, 64);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(45, 13);
            this.lblPenalty.TabIndex = 2;
            this.lblPenalty.Text = "Penatly:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnPenatly
            // 
            this.btnPenatly.Location = new System.Drawing.Point(111, 106);
            this.btnPenatly.Name = "btnPenatly";
            this.btnPenatly.Size = new System.Drawing.Size(75, 23);
            this.btnPenatly.TabIndex = 4;
            this.btnPenatly.Text = "Add Penatly";
            this.btnPenatly.UseVisualStyleBackColor = true;
            this.btnPenatly.Click += new System.EventHandler(this.btnPenatly_Click);
            // 
            // Penatly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPenatly);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPenalty);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.textBox1);
            this.Name = "Penatly";
            this.Size = new System.Drawing.Size(230, 132);
            this.Load += new System.EventHandler(this.Penatly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPenatly;
    }
}
