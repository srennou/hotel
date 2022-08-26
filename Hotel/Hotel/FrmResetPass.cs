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
    public partial class FrmResetPass : Form
    {
        public FrmResetPass()
        {
            InitializeComponent();
        }

        private void btnAccepte_Click(object sender, EventArgs e)
        {
            string value = lblUnique.Text;
            if (txtPass.Text == txtConfPass.Text)
            {
                SqlCommand update = new SqlCommand($"UPDATE [USER] SET password = '{txtPass.Text}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
                Close();
            }
            else
                MessageBox.Show("Confirm password");
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
