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
    
    public partial class BorrowBook : UserControl
    {
        
        private static BorrowBook _instance;
        public static BorrowBook Instance
        {
            get
            {
                if (_instance == null)

             _instance = new BorrowBook();
                return _instance;

            }
        }
        public BorrowBook()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
            issuedatetimepicker.MinDate = DateTime.Today;
          
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBookname.Text = "";
            txtAuthor.Text = "";
            comboBox1.SelectedValue = 0;
           // dateTimePicker1.MinDate = DateTime.Today;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtBookname.Text+".txt"))
            {

                MessageBox.Show("Book not Found!");
            }
            else
            {
                TextReader tr = new StreamReader(txtBookname.Text+ ".txt");
                string author = tr.ReadLine();
                if (author == txtAuthor.Text)
                {
                    MessageBox.Show("Book Available");
                }

            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

        
    }
