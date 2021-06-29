namespace Login
{
    partial class BookRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRecords));
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1Quantity = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateRecordbtn = new System.Windows.Forms.Button();
            this.clearRecordbtn = new System.Windows.Forms.Button();
            this.addrbookecordbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BooknameRecordtxt = new System.Windows.Forms.TextBox();
            this.Bookidtxt = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(610, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 47);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 40);
            this.panel2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Book Records";
            // 
            // numericUpDown1Quantity
            // 
            this.numericUpDown1Quantity.Location = new System.Drawing.Point(332, 240);
            this.numericUpDown1Quantity.Name = "numericUpDown1Quantity";
            this.numericUpDown1Quantity.Size = new System.Drawing.Size(251, 20);
            this.numericUpDown1Quantity.TabIndex = 39;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(332, 292);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(251, 81);
            this.richTextBox1.TabIndex = 40;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Student Details:";
            // 
            // UpdateRecordbtn
            // 
            this.UpdateRecordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRecordbtn.Location = new System.Drawing.Point(415, 418);
            this.UpdateRecordbtn.Name = "UpdateRecordbtn";
            this.UpdateRecordbtn.Size = new System.Drawing.Size(149, 47);
            this.UpdateRecordbtn.TabIndex = 43;
            this.UpdateRecordbtn.Text = "Update Record";
            this.UpdateRecordbtn.UseVisualStyleBackColor = true;
            // 
            // clearRecordbtn
            // 
            this.clearRecordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearRecordbtn.Location = new System.Drawing.Point(264, 416);
            this.clearRecordbtn.Name = "clearRecordbtn";
            this.clearRecordbtn.Size = new System.Drawing.Size(128, 47);
            this.clearRecordbtn.TabIndex = 42;
            this.clearRecordbtn.Text = "Clear Record";
            this.clearRecordbtn.UseVisualStyleBackColor = true;
            this.clearRecordbtn.Click += new System.EventHandler(this.clearRecordbtn_Click);
            // 
            // addrbookecordbtn
            // 
            this.addrbookecordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrbookecordbtn.Location = new System.Drawing.Point(110, 416);
            this.addrbookecordbtn.Name = "addrbookecordbtn";
            this.addrbookecordbtn.Size = new System.Drawing.Size(121, 47);
            this.addrbookecordbtn.TabIndex = 41;
            this.addrbookecordbtn.Text = "Add Record";
            this.addrbookecordbtn.UseVisualStyleBackColor = true;
            this.addrbookecordbtn.Click += new System.EventHandler(this.addrbookecordbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // BooknameRecordtxt
            // 
            this.BooknameRecordtxt.Location = new System.Drawing.Point(332, 144);
            this.BooknameRecordtxt.Name = "BooknameRecordtxt";
            this.BooknameRecordtxt.Size = new System.Drawing.Size(251, 20);
            this.BooknameRecordtxt.TabIndex = 37;
            // 
            // Bookidtxt
            // 
            this.Bookidtxt.Location = new System.Drawing.Point(332, 99);
            this.Bookidtxt.Name = "Bookidtxt";
            this.Bookidtxt.Size = new System.Drawing.Size(251, 20);
            this.Bookidtxt.TabIndex = 36;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(169, 144);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(106, 20);
            this.lblBookName.TabIndex = 35;
            this.lblBookName.Text = "Book Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Book Out Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Qty:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(169, 99);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 20);
            this.lbl1.TabIndex = 32;
            this.lbl1.Text = "Book Id:";
            // 
            // BookRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numericUpDown1Quantity);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateRecordbtn);
            this.Controls.Add(this.clearRecordbtn);
            this.Controls.Add(this.addrbookecordbtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BooknameRecordtxt);
            this.Controls.Add(this.Bookidtxt);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Name = "BookRecords";
            this.Size = new System.Drawing.Size(814, 523);
            this.Load += new System.EventHandler(this.BookRecords_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1Quantity;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateRecordbtn;
        private System.Windows.Forms.Button clearRecordbtn;
        private System.Windows.Forms.Button addrbookecordbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox BooknameRecordtxt;
        private System.Windows.Forms.TextBox Bookidtxt;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
    }
}
