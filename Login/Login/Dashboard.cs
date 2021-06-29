using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Dashboard : Form
    {
        public Dashboard(String val)
        {
            InitializeComponent();
            Nameofuserbl.Text = val;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbooksbtn_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Add(BorrowBook.Instance);
            BorrowBook.Instance.BringToFront(); 
        }

       

        private void Articlesbtn_Click(object sender, EventArgs e)
        {
            panelhome.Controls.Add(Articles.Instance);
            Articles.Instance.BringToFront();

        }

  

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void panelhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkpenaltybtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have no penalties");
        }

        private void userbl_Click(object sender, EventArgs e)
        {

        }
    }
}
