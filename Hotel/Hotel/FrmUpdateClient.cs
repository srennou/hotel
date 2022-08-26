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
    public partial class FrmUpdateClient : Form
    {
        public FrmUpdateClient()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sexe = "Homme";
            if (rbnFemme.Checked)
                sexe = rbnFemme.Text;
            SqlCommand firstUpdate = new SqlCommand($"UPDATE client SET sexe = '{sexe}' WHERE cin LIKE '{txtCIN.Text}' ",
                                                        Program.MyConnection());
            if (txtNom.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE client SET nom = '{txtNom.Text}' WHERE cin LIKE '{txtCIN.Text}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtPrenom.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE client SET prenom = '{txtPrenom.Text}' WHERE cin LIKE '{txtCIN.Text}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtEmail.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE client SET email = '{txtEmail.Text}' WHERE cin LIKE '{txtCIN.Text}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtTelephone.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE client SET telephone = '{txtTelephone.Text}' WHERE cin LIKE '{txtCIN.Text}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtAdresse.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE client SET adresse = '{txtAdresse.Text}' WHERE cin LIKE '{txtCIN.Text}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            new FrmClients().Show();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new FrmClients().Show();
            Close();
        }
    }
}
