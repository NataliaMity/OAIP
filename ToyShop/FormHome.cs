using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyShop
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FormFeedback f1 = new FormFeedback ();
            f1.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrder f2 = new FormOrder();
            f2.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FormHelp f3 = new FormHelp();
            f3.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}