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
    public partial class Assessments : UserControl
    {
        private static Assessments _instance;
        public static Assessments Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Assessments();
                return _instance;

            }
        }
        public Assessments()
        {
            InitializeComponent();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Assessments_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            topictxt.Text = "";
            deptcombo.SelectedValue = 0;
            languageCmb.SelectedValue = 0;
            Publishertxt.Text = "";
            yearPublishedDtp.MinDate = DateTime.Today;
        }

        private void courseCodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TextWriter tw = new StreamWriter(topictxt.Text + ".txt");
            tw.WriteLine(Publishertxt.Text);
            tw.WriteLine("Publishers Names : " + Publishertxt.Text);
            tw.WriteLine("Article Topic :" + topictxt.Text);
            tw.WriteLine("Department :" + deptcombo.SelectedItem);
            tw.WriteLine("Year Published :" + yearPublishedDtp.Text);
            tw.WriteLine("Article Language :" + languageCmb.SelectedItem);

            tw.Dispose();
            tw.Close();
        }
    }
}
