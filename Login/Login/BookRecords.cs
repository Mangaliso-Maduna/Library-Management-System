using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    public partial class BookRecords : UserControl
    {
        private static BookRecords _instance;
        public static BookRecords Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new BookRecords();
                return _instance;

            }
        }
        public BookRecords()
        {
            InitializeComponent();
        }

        private void BookRecords_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addrbookecordbtn_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(Bookidtxt.Text + ".txt");
            tw.WriteLine(" BOOK NAME: :" + BooknameRecordtxt.Text);
            tw.WriteLine("Date Book Issued:" + dateTimePicker1.Text);
            tw.WriteLine("ISBN : " + Bookidtxt.Text);
            tw.WriteLine("Quantity :" + numericUpDown1Quantity.Value);
            tw.WriteLine("Student Details :" + richTextBox1.Text);

            tw.Dispose();
            tw.Close();

            MessageBox.Show("Records succesfully added");
        }

        private void clearRecordbtn_Click(object sender, EventArgs e)
        {
            Bookidtxt.Text = "";
            BooknameRecordtxt.Text = "";
            dateTimePicker1.MinDate = DateTime.Today;
            numericUpDown1Quantity.Value = 0;
            richTextBox1.Text = "";
        }
    }
}
