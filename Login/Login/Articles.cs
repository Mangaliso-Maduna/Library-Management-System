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
    public partial class Articles : UserControl
    {
        private static Articles _instance;
        public static Articles Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Articles();
                return _instance;

            }
        }
        public Articles()
        {
            InitializeComponent();
        }

        private void Articles_Load(object sender, EventArgs e)
        {

        }

        private void btnClearArticles_Click(object sender, EventArgs e)
        {
            topictxt.Text = "";
            deptComboArtıcle.SelectedIndex = 0;
            LanguageCmb.SelectedIndex = 0;
            publishertxt.Text = "";
            dateTimePicker1.MinDate = DateTime.Today;

        }

        private void AddArticlesbtn_Click(object sender, EventArgs e)
        {
             if (!File.Exists(topictxt.Text+".txt"))
            {

                MessageBox.Show("Article not Found!");
            }
            else
            {
                TextReader tr = new StreamReader(topictxt.Text+ ".txt");
                string Publisher = tr.ReadLine();
                if (Publisher == publishertxt.Text)
                {
                    MessageBox.Show("Article Available");
                }

            }
            
            {

            }
        }
    }
}
