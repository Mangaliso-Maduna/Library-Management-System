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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1username_TextChanged(object sender, EventArgs e)
        {
          //  Login s = new Login();

            //s.Username = textBox1username.Text;

        }

        private void textBox1username_Enter(object sender, EventArgs e)
        {
            if (textBox1username.Text == "Username")
            {
                textBox1username.Text = "";
            }
        }

        private void textBox2password_Enter(object sender, EventArgs e)
        {
            if (textBox2password.Text=="Password")
            {
                textBox2password.Text = "";
            }
        }

        private void textBox1username_Leave(object sender, EventArgs e)
        {
            if (textBox1username.Text.Trim()=="")
            {
                textBox1username.Text = "Username";
            }
        }

        private void textBox2password_Leave(object sender, EventArgs e)
        {
            if (textBox2password.Text.Trim()=="")
            {
                textBox2password.Text = "Password";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewMemberRegistration member = new NewMemberRegistration();
            member.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1username.Text == "Mangaliso" && textBox2password.Text == "Mad1234") &&
               (radioButton1Admin.Checked))
            {
                this.Hide();
         
                AdminSite admin = new AdminSite();
                admin.Show();


            }
            else if (radioButton2Student.Checked==true)
            {
              
                String user = textBox1username.Text;
                Dashboard db = new Dashboard(char.ToUpper(user[0]) + user.Substring(1));

                if (!File.Exists(textBox1username.Text + ".txt"))
                {

                    MessageBox.Show("Username does not exit");
                }
                else
                {
                    TextReader tr = new StreamReader(textBox1username.Text + ".txt");
                    string pass = tr.ReadLine();
                    if (pass == textBox2password.Text)
                    {

                        this.Hide();
                        db.Show();
                    }
                    else
                    {
                        MessageBox.Show("invalid password");
                    }

                }


            }
            else if (radioButton1Admin.Checked==true)
            {
                DialogResult res = MessageBox.Show("Access denied!, you cannot signin as an admin","WARNING",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2password_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
