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
    public partial class NewMemberRegistration : Form
    {

        Form1 f1;
       
        public NewMemberRegistration()
        {
            InitializeComponent();
            f1 = new Form1();
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            
          
            f1.Show();
        }
        
          
        private void button1_Click(object sender, EventArgs e)
        {

            TextWriter tw = new StreamWriter(txtUsername.Text + ".txt");
            tw.WriteLine(passwordtextBox2.Text);
            tw.WriteLine(fullnamestxt1.Text);
            tw.WriteLine(txtUsername.Text);
            
            tw.WriteLine(dateTimePicker1newuser.Text);
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                tw.WriteLine(radioButton1.Text);
            }
            else
            
                tw.WriteLine(radioButton2.Text);

                tw.WriteLine(personalEmailtxt.Text);
                tw.WriteLine(mobilenumbertxt.Text);

                tw.WriteLine(richTextBox1.Text);

                tw.Dispose();
                tw.Close();
                MessageBox.Show("Succesfully Registered");
            this.Hide();
            f1.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void password1txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (passwordtextBox2.Text==txtPassword.Text)
            {
                lblPasswordValidate.Visible = true;
                lblPasswordValidate.ForeColor = Color.Green;
                lblPasswordValidate.Text = "passwords match";
            }
            else
            {
                lblPasswordValidate.Visible = true;
                lblPasswordValidate.ForeColor = Color.Red;
                lblPasswordValidate.Text = "Incorrect!";
            }
        }

        private void fullnamestxt1_Enter(object sender, EventArgs e)
        {
            if (fullnamestxt1.Text== "Your Full Names")
            {
                fullnamestxt1.Text = "";
            }
        }

        private void fullnamestxt1_Leave(object sender, EventArgs e)
        {
            if (fullnamestxt1.Text.Trim()=="")
            {
                fullnamestxt1.Text = "Your Full Names";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text== "Your Prefered Username")
            {
                txtUsername.Text = "";
            }
        }

        private void personalEmailtxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void mobilenumbertxt_TextChanged(object sender, EventArgs e)
        {
            if (mobilenumbertxt.Text=="Mobile Number")
            {
                mobilenumbertxt.Text = " ";
            }
        }
        
        private void personalEmailtxt_Leave(object sender, EventArgs e)
        {
            if (personalEmailtxt.Text.Trim()==" ")
            {
                personalEmailtxt.Text = "Personal email";
            }
        }

        private void mobilenumbertxt_Leave(object sender, EventArgs e)
        {
            if (mobilenumbertxt.Text.Trim()==" ")
            {
                mobilenumbertxt.Text = " ";
            }
        }

        private void personalEmailtxt_Enter(object sender, EventArgs e)
        {

            if (personalEmailtxt.Text == "Personal email")
            {
                personalEmailtxt.Text = "";
            }
        }

        private void mobilenumbertxt_Enter(object sender, EventArgs e)
        {

            if (mobilenumbertxt.Text == "Mobile Number")
            {
                mobilenumbertxt.Text = "";
            }
        }

        private void fullnamestxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewMemberRegistration_Load(object sender, EventArgs e)
        {

        }
    }
    }

