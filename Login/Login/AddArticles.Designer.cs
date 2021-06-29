namespace Login
{
    partial class Assessments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assessments));
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1header = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.yearPublishedDtp = new System.Windows.Forms.DateTimePicker();
            this.languageCmb = new System.Windows.Forms.ComboBox();
            this.deptcombo = new System.Windows.Forms.ComboBox();
            this.topictxt = new System.Windows.Forms.TextBox();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblLangauge = new System.Windows.Forms.Label();
            this.lblCmbYear = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.Publishertxt = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(269, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 49);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 49);
            this.panel1.TabIndex = 26;
            // 
            // label1header
            // 
            this.label1header.AutoSize = true;
            this.label1header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1header.Location = new System.Drawing.Point(365, 13);
            this.label1header.Name = "label1header";
            this.label1header.Size = new System.Drawing.Size(79, 24);
            this.label1header.TabIndex = 1;
            this.label1header.Text = "Articles";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(448, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 49);
            this.button2.TabIndex = 26;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(88, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add Articles:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yearPublishedDtp
            // 
            this.yearPublishedDtp.Location = new System.Drawing.Point(298, 339);
            this.yearPublishedDtp.Name = "yearPublishedDtp";
            this.yearPublishedDtp.Size = new System.Drawing.Size(290, 20);
            this.yearPublishedDtp.TabIndex = 23;
            this.yearPublishedDtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // languageCmb
            // 
            this.languageCmb.FormattingEnabled = true;
            this.languageCmb.Items.AddRange(new object[] {
            "English",
            "Turkish"});
            this.languageCmb.Location = new System.Drawing.Point(298, 277);
            this.languageCmb.Name = "languageCmb";
            this.languageCmb.Size = new System.Drawing.Size(290, 21);
            this.languageCmb.TabIndex = 21;
            // 
            // deptcombo
            // 
            this.deptcombo.FormattingEnabled = true;
            this.deptcombo.Items.AddRange(new object[] {
            "SELECT DEPARTMENT",
            "Engineering",
            "Humanities",
            "Arts",
            "Economics"});
            this.deptcombo.Location = new System.Drawing.Point(298, 207);
            this.deptcombo.Name = "deptcombo";
            this.deptcombo.Size = new System.Drawing.Size(290, 21);
            this.deptcombo.TabIndex = 20;
            this.deptcombo.Text = "--SELECT DEPARTMENT--";
            // 
            // topictxt
            // 
            this.topictxt.Location = new System.Drawing.Point(298, 95);
            this.topictxt.Name = "topictxt";
            this.topictxt.Size = new System.Drawing.Size(290, 20);
            this.topictxt.TabIndex = 19;
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(130, 208);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(109, 20);
            this.lbldepartment.TabIndex = 18;
            this.lbldepartment.Text = "Department:";
            // 
            // lblLangauge
            // 
            this.lblLangauge.AutoSize = true;
            this.lblLangauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLangauge.Location = new System.Drawing.Point(130, 278);
            this.lblLangauge.Name = "lblLangauge";
            this.lblLangauge.Size = new System.Drawing.Size(94, 20);
            this.lblLangauge.TabIndex = 17;
            this.lblLangauge.Text = "Langauge:";
            // 
            // lblCmbYear
            // 
            this.lblCmbYear.AutoSize = true;
            this.lblCmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmbYear.Location = new System.Drawing.Point(130, 339);
            this.lblCmbYear.Name = "lblCmbYear";
            this.lblCmbYear.Size = new System.Drawing.Size(135, 20);
            this.lblCmbYear.TabIndex = 15;
            this.lblCmbYear.Text = "Year Published:";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(130, 93);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(57, 20);
            this.lblTopic.TabIndex = 14;
            this.lblTopic.Text = "Topic:";
            // 
            // Publishertxt
            // 
            this.Publishertxt.Location = new System.Drawing.Point(298, 134);
            this.Publishertxt.Name = "Publishertxt";
            this.Publishertxt.Size = new System.Drawing.Size(290, 20);
            this.Publishertxt.TabIndex = 28;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(130, 132);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(88, 20);
            this.lblPublisher.TabIndex = 27;
            this.lblPublisher.Text = "Publisher:";
            // 
            // Assessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.Publishertxt);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yearPublishedDtp);
            this.Controls.Add(this.languageCmb);
            this.Controls.Add(this.deptcombo);
            this.Controls.Add(this.topictxt);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblLangauge);
            this.Controls.Add(this.lblCmbYear);
            this.Controls.Add(this.lblTopic);
            this.Name = "Assessments";
            this.Size = new System.Drawing.Size(819, 523);
            this.Load += new System.EventHandler(this.Assessments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1header;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker yearPublishedDtp;
        private System.Windows.Forms.ComboBox languageCmb;
        private System.Windows.Forms.ComboBox deptcombo;
        private System.Windows.Forms.TextBox topictxt;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblLangauge;
        private System.Windows.Forms.Label lblCmbYear;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox Publishertxt;
        private System.Windows.Forms.Label lblPublisher;
    }
}
