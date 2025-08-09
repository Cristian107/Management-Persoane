using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class CopyRight : UserControl
    {
        public CopyRight()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Proiect Paw1063", "Informații", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}