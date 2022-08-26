using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FrmEspaceAdmin : Form
    {
        public FrmEspaceAdmin()
        {
            InitializeComponent();
        }

        private void pcbUser_Click(object sender, EventArgs e)
        {
            new FrmUser().Show();
            Close();
        }

        private void pcbOption_Click(object sender, EventArgs e)
        {
            new FrmOption().Show();
            Close();
        }

        private void pcbGuid_Click(object sender, EventArgs e)
        {
            new FrmGuid().Show();
            Close();
        }

        private void pcbChambre_Click(object sender, EventArgs e)
        {
            new FrmChambre().Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            Close();
        }
    }
}
