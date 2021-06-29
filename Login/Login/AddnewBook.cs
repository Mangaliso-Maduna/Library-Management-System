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
    public partial class AddnewBook : UserControl
    {
       
       
        private static AddnewBook _instance;
        public static AddnewBook Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new AddnewBook();
                return _instance;

            }
        }
        public AddnewBook()
        {
            InitializeComponent();

            
        }

        private void Addbookbtn_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(BookNametxt.Text + ".txt");
            tw.WriteLine(Authortxt.Text);
            tw.WriteLine(BookNametxt.Text);
            tw.WriteLine("ISBN:"+bookidTXT.Text);
            tw.WriteLine(departmentcmb.SelectedItem);
            tw.WriteLine(pricetxt.Text);
            tw.WriteLine(numericUpDown1.Value);

            tw.Dispose();
            tw.Close();

        }


        /*   public void ReadBookInfo()
         {

             using (StreamReader SR = new StreamReader("BookRecords.txt")) //UserAccounts.txt
             {
                 while (SR.EndOfStream == false)
                 {
                     BookInfo.Add(SR.ReadLine());
                 }
             }

         }*/

        private void addBOOKpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void departmentcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookNametxt_Leave(object sender, EventArgs e)
        {
            if(BookNametxt.Text.Trim()==" ")
            {
                BookNametxt.Text = "Enter book name";
            }
        }

        private void BookNametxt_Enter(object sender, EventArgs e)
        {
            if (BookNametxt.Text== "Enter book name")
            {
                BookNametxt.Text = " ";
            }
        }

        private void Authortxt_Leave(object sender, EventArgs e)
        {
            if (BookNametxt.Text.Trim()=="")
            {
                BookNametxt.Text = "Give the writer(s) name";
            }
        }

        private void Authortxt_Enter(object sender, EventArgs e)
        {
            if (Authortxt.Text== "Give the writer(s) name")
            {
                Authortxt.Text = " ";
            }
        }

        private void pricetxt_Leave(object sender, EventArgs e)
        {
            if (pricetxt.Text.Trim()=="")
            {
                pricetxt.Text = "Amount(TRY)";
            }
        }

        private void pricetxt_Enter(object sender, EventArgs e)
        {
            if (pricetxt.Text=="Amount(TRY)")
            {
                pricetxt.Text = "";
            }
        }

        private void StuClearBookbtn_Click(object sender, EventArgs e)
        {
            BookNametxt.Text = "";
            departmentcmb.SelectedIndex = 0;
            richTextBox1.Text = "";
            bookidTXT.Text = "";
            Authortxt.Text = "";
            pricetxt.Text = "";
            numericUpDown1.Value = 0;
        }

        private void AddbookCancelBtn_Click(object sender, EventArgs e)
        {
            AdminSite admin = new AdminSite();
            admin.Show();
        }

        private void AddbookCancelBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
