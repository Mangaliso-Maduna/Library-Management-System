using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AdminSite : Form
    {
        public AdminSite()
        {
            InitializeComponent();
            
        }

        private void penaltyBtn_Click(object sender, EventArgs e)
        {
            panel2home.Controls.Add(Penatly.Instance);
            Penatly.Instance.BringToFront();
        }

        private void Addbookbtn_Click(object sender, EventArgs e)
        {
            //UserControl for Addning a new book
            panel2home.Controls.Add(AddnewBook.Instance);
            AddnewBook.Instance.BringToFront();

        }

        

        private void adminLogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

      

        private void button1HOME_Click(object sender, EventArgs e)
        {
            panel2home.Show();
            panel2home.BringToFront();

        }

       

        private void addnewBook1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         
        }

        private void panel2home_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void AdminSite_Load_1(object sender, EventArgs e)
        {
            
        }

        private void AddStuBtn_Click(object sender, EventArgs e)
        {
            panel2home.Controls.Add(AddNewStudentControl.Instance);
            AddNewStudentControl.Instance.BringToFront();
        }

        private void bookReportBtn_Click(object sender, EventArgs e)
        {
            panel2home.Controls.Add(BookRecords.Instance);
            BookRecords.Instance.BringToFront();
        }

        private void btnAddArticles_Click(object sender, EventArgs e)
        {
            panel2home.Controls.Add(Assessments.Instance);
            Assessments.Instance.BringToFront();
        }

      
    }
}
