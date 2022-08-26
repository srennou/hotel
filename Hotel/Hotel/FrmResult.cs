using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FrmResult : Form
    {
        public FrmResult()
        {
            InitializeComponent();
        }

        private void FrmResult_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            SqlCommand insert = new SqlCommand($"INSERT INTO reservation values ('{txtCIN.Text}', '{txtNum.Text}', '{txtDateDebut.Text}', '{txtDatefin.Text}', {txtTotal.Text})",
                                                            Program.MyConnection());
            int insertCheck = (int)insert.ExecuteNonQuery();
            MessageBox.Show("La reservation est valider");
            new FrmEspaceUser().Show();
            Hide();
        }
    }
}
