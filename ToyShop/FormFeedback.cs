using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToyShop
{
    public partial class FormFeedback : Form
    {
        public FormFeedback()
        {
            InitializeComponent();
        }

        private void btnExitFeedback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(sfd.FileName);
                streamWriter.WriteLine(richTxtBoxFeedback.Text);
                streamWriter.Close();
            }
        }
    }
}
