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
    public partial class FrmEspaceUser : Form
    {
        public FrmEspaceUser()
        {
            InitializeComponent();
        }

        private void pcbReservation_Click(object sender, EventArgs e)
        {
            new FrmAddClient().Show();
            Close();
        }

        private void pcbClients_Click(object sender, EventArgs e)
        {
            new FrmClients().Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            Close();
        }

        private void pcbOffre_Click(object sender, EventArgs e)
        {
            new FrmOffre().Show();
            Close();
        }
    }
}
