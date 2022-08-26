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
    public partial class FrmUpdateUser : Form
    {
        public FrmUpdateUser()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string type = "user";
            int is_active = 0;
            if (rbnAdmin.Checked)
                type = rbnAdmin.Text;
            if (chbActive.Checked)
                is_active = 1;
            var value = lblUnique.Text;
            SqlCommand firstUpdate = new SqlCommand($"UPDATE [USER] SET type = '{type}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
            int firstCheck = (int)firstUpdate.ExecuteNonQuery();
            SqlCommand secondUpdate = new SqlCommand($"UPDATE [USER] SET is_active = {is_active} WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
            int SecondCheck = (int)secondUpdate.ExecuteNonQuery();
            if (txtNom.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [USER] SET nom = '{txtNom.Text}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtPrenom.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [USER] SET prenom = '{txtPrenom.Text}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtEmail.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [USER] SET email = '{txtEmail.Text}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtTelephone.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [USER] SET telephone = '{txtTelephone.Text}' WHERE email LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            new FrmUser().Show();
            Close();
        }

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {
            string value = txtEmail.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmResetPass myForm = new FrmResetPass();
            myForm.lblUnique.Text = lblUnique.Text;
            myForm.ShowDialog();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            new FrmUser().Show();
            Close();
        }
    }
}
