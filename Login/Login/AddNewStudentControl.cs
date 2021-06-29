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
    public partial class AddNewStudentControl : UserControl
    {
        private static AddNewStudentControl _instance;
        public static AddNewStudentControl Instance
        {
            get
            {
                if (_instance==null)
                
                    _instance = new AddNewStudentControl();
                    return _instance;
                
            }
        }
        public AddNewStudentControl()
        {
            InitializeComponent();
        }

        private void addBOOKpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (userpassword2txt.Text==newuserpasswordxt.Text)
            {
                passwordcheckelbl.Visible = true;
                passwordcheckelbl.ForeColor = Color.Green;
                
            }
            else
            {
                errorProvider1.SetError(userpassword2txt, "Passwords mismatch");
                
            }
        }

        private void richTextBox1Adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddbookCancelBtn_Click(object sender, EventArgs e)
        {
            
             this.Hide();
      
        }

        private void AddnewStudentkbtn_Click(object sender, EventArgs e)
        {
            
            TextWriter tw = new StreamWriter(StudentNametxt.Text + ".txt");
            tw.WriteLine(userpassword2txt.Text);
            tw.WriteLine(" Student Names :" + StudentNametxt.Text);
            tw.WriteLine("Date of Birth : " + dateTimePicker1.Text);
            tw.WriteLine(" Student Department :" + departmentcmb.SelectedItem);
            //Gender
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                tw.WriteLine(" Gender :"+radioButton1.Text);
            }
            else
                tw.WriteLine("Gender :"+radioButton2.Text);

            tw.WriteLine("City :" + comboBox1.SelectedItem);
            tw.WriteLine("Address :" + richTextBox1Adress.Text);
            tw.WriteLine("Email Adress :" + registerStuemailTXT.Text);
            tw.WriteLine("Mobile Number :" + mobilenumbertxt.Text);

            tw.Dispose();
            tw.Close();

        }

        private void registerStuemailTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentNametxt_Leave(object sender, EventArgs e)
        {
            if (StudentNametxt.Text.Trim()=="")
            {
                StudentNametxt.Text = "Enter student name";
            }
        }

        private void StudentNametxt_Enter(object sender, EventArgs e)
        {
            if (StudentNametxt.Text=="Enter Student name")
            {
                StudentNametxt.Text = "";
            }
        }

        private void passwordcheckelbl_Click(object sender, EventArgs e)
        {

        }

        private void StuClearBookbtn_Click(object sender, EventArgs e)
        {
            StudentNametxt.Text = " ";
            departmentcmb.SelectedIndex = 0;
            dateTimePicker1.MinDate = DateTime.Today;
            comboBox1.SelectedIndex = 0;
            richTextBox1Adress.Text = " ";
            registerStuemailTXT.Text = " ";
            mobilenumbertxt.Text = " ";
            newuserpasswordxt.Text = " ";
            userpassword2txt.Text = " ";
        }
    }
}
