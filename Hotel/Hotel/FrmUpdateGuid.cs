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
    public partial class FrmUpdateGuid : Form
    {
        public FrmUpdateGuid()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = lblUnique.Text;
            if (txtNom.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [GUID] SET nom = '{txtNom.Text}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtPrenom.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [GUID] SET prenom = '{txtPrenom.Text}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtEmail.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [GUID] SET email = '{txtEmail.Text}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtTelephone.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [GUID] SET telephone = '{txtTelephone.Text}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            new FrmGuid().Show();
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            new FrmGuid().Show();
            Close();
        }
    }
}
