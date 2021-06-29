using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Penatly : UserControl
    {
        private static Penatly _instance;
        public static Penatly Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Penatly();
                return _instance;
            }
        }
        public Penatly()
        {
            InitializeComponent();
        }

        private void Penatly_Load(object sender, EventArgs e)
        {

        }

        private void btnPenatly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Penatly Issued");
        }
    }
}
