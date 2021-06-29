namespace Login
{
    partial class AddnewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddnewBook));
            this.addBOOKpanel = new System.Windows.Forms.Panel();
            this.bookidTXT = new System.Windows.Forms.TextBox();
            this.labelBookid = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AddbookCancelBtn = new System.Windows.Forms.Button();
            this.StuClearBookbtn = new System.Windows.Forms.Button();
            this.Addnewbookbtn = new System.Windows.Forms.Button();
            this.departmentcmb = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Authortxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.BookNametxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBOOKpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBOOKpanel
            // 
            this.addBOOKpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBOOKpanel.BackgroundImage")));
            this.addBOOKpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBOOKpanel.Controls.Add(this.bookidTXT);
            this.addBOOKpanel.Controls.Add(this.labelBookid);
            this.addBOOKpanel.Controls.Add(this.numericUpDown1);
            this.addBOOKpanel.Controls.Add(this.AddbookCancelBtn);
            this.addBOOKpanel.Controls.Add(this.StuClearBookbtn);
            this.addBOOKpanel.Controls.Add(this.Addnewbookbtn);
            this.addBOOKpanel.Controls.Add(this.departmentcmb);
            this.addBOOKpanel.Controls.Add(this.richTextBox1);
            this.addBOOKpanel.Controls.Add(this.Authortxt);
            this.addBOOKpanel.Controls.Add(this.pricetxt);
            this.addBOOKpanel.Controls.Add(this.BookNametxt);
            this.addBOOKpanel.Controls.Add(this.label10);
            this.addBOOKpanel.Controls.Add(this.label9);
            this.addBOOKpanel.Controls.Add(this.panel1);
            this.addBOOKpanel.Controls.Add(this.label6);
            this.addBOOKpanel.Controls.Add(this.label5);
            this.addBOOKpanel.Controls.Add(this.label4);
            this.addBOOKpanel.Controls.Add(this.label3);
            this.addBOOKpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBOOKpanel.Location = new System.Drawing.Point(0, 0);
            this.addBOOKpanel.Name = "addBOOKpanel";
            this.addBOOKpanel.Size = new System.Drawing.Size(814, 523);
            this.addBOOKpanel.TabIndex = 2;
            this.addBOOKpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addBOOKpanel_Paint);
            // 
            // bookidTXT
            // 
            this.bookidTXT.Location = new System.Drawing.Point(175, 262);
            this.bookidTXT.Name = "bookidTXT";
            this.bookidTXT.Size = new System.Drawing.Size(221, 20);
            this.bookidTXT.TabIndex = 18;
            // 
            // labelBookid
            // 
            this.labelBookid.AutoSize = true;
            this.labelBookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookid.Location = new System.Drawing.Point(17, 262);
            this.labelBookid.Name = "labelBookid";
            this.labelBookid.Size = new System.Drawing.Size(66, 20);
            this.labelBookid.TabIndex = 17;
            this.labelBookid.Text = "Book id:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(175, 399);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(221, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // AddbookCancelBtn
            // 
            this.AddbookCancelBtn.Location = new System.Drawing.Point(507, 442);
            this.AddbookCancelBtn.Name = "AddbookCancelBtn";
            this.AddbookCancelBtn.Size = new System.Drawing.Size(121, 55);
            this.AddbookCancelBtn.TabIndex = 15;
            this.AddbookCancelBtn.Text = "Cancel";
            this.AddbookCancelBtn.UseVisualStyleBackColor = true;
            this.AddbookCancelBtn.Click += new System.EventHandler(this.AddbookCancelBtn_Click_1);
            // 
            // StuClearBookbtn
            // 
            this.StuClearBookbtn.Location = new System.Drawing.Point(634, 442);
            this.StuClearBookbtn.Name = "StuClearBookbtn";
            this.StuClearBookbtn.Size = new System.Drawing.Size(121, 55);
            this.StuClearBookbtn.TabIndex = 14;
            this.StuClearBookbtn.Text = "Clear";
            this.StuClearBookbtn.UseVisualStyleBackColor = true;
            this.StuClearBookbtn.Click += new System.EventHandler(this.StuClearBookbtn_Click);
            // 
            // Addnewbookbtn
            // 
            this.Addnewbookbtn.Location = new System.Drawing.Point(380, 442);
            this.Addnewbookbtn.Name = "Addnewbookbtn";
            this.Addnewbookbtn.Size = new System.Drawing.Size(121, 55);
            this.Addnewbookbtn.TabIndex = 13;
            this.Addnewbookbtn.Text = "AddBook";
            this.Addnewbookbtn.UseVisualStyleBackColor = true;
            this.Addnewbookbtn.Click += new System.EventHandler(this.Addbookbtn_Click);
            // 
            // departmentcmb
            // 
            this.departmentcmb.FormattingEnabled = true;
            this.departmentcmb.Items.AddRange(new object[] {
            "---Select Department---",
            "Electrical Engineering",
            "Mechatronics Engineering",
            "Economics",
            "Accounting",
            "Law",
            "Computer Sciences",
            "Software Engineering"});
            this.departmentcmb.Location = new System.Drawing.Point(175, 136);
            this.departmentcmb.Name = "departmentcmb";
            this.departmentcmb.Size = new System.Drawing.Size(221, 21);
            this.departmentcmb.TabIndex = 2;
            this.departmentcmb.Text = "--SELECT--";
            this.departmentcmb.SelectedIndexChanged += new System.EventHandler(this.departmentcmb_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(175, 181);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 75);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Authortxt
            // 
            this.Authortxt.Location = new System.Drawing.Point(175, 314);
            this.Authortxt.Name = "Authortxt";
            this.Authortxt.Size = new System.Drawing.Size(221, 20);
            this.Authortxt.TabIndex = 7;
            this.Authortxt.Text = "Give the writer(s) name";
            this.Authortxt.Enter += new System.EventHandler(this.Authortxt_Enter);
            this.Authortxt.Leave += new System.EventHandler(this.Authortxt_Leave);
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(175, 356);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(221, 20);
            this.pricetxt.TabIndex = 9;
            this.pricetxt.Text = "Amount(TRY)";
            this.pricetxt.Enter += new System.EventHandler(this.pricetxt_Enter);
            this.pricetxt.Leave += new System.EventHandler(this.pricetxt_Leave);
            // 
            // BookNametxt
            // 
            this.BookNametxt.Location = new System.Drawing.Point(175, 90);
            this.BookNametxt.Name = "BookNametxt";
            this.BookNametxt.Size = new System.Drawing.Size(221, 20);
            this.BookNametxt.TabIndex = 1;
            this.BookNametxt.Text = "Enter book name";
            this.BookNametxt.TextChanged += new System.EventHandler(this.BookNametxt_TextChanged);
            this.BookNametxt.Enter += new System.EventHandler(this.BookNametxt_Enter);
            this.BookNametxt.Leave += new System.EventHandler(this.BookNametxt_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Details:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quantity:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 51);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Add new book";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Author(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departmant:";
            // 
            // AddnewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addBOOKpanel);
            this.Name = "AddnewBook";
            this.Size = new System.Drawing.Size(814, 523);
            this.addBOOKpanel.ResumeLayout(false);
            this.addBOOKpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addBOOKpanel;
        private System.Windows.Forms.TextBox bookidTXT;
        private System.Windows.Forms.Label labelBookid;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AddbookCancelBtn;
        private System.Windows.Forms.Button StuClearBookbtn;
        private System.Windows.Forms.Button Addnewbookbtn;
        private System.Windows.Forms.ComboBox departmentcmb;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox Authortxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox BookNametxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
