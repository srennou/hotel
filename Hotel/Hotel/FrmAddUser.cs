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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type = "user";
            int is_active = 0;
            if (rbnActive.Checked)
                is_active = 1;
            if (rbnAdmin.Checked)
                type = rbnAdmin.Text;
            if (txtPass.Text == txtConfPass.Text)
            {
                if(txtNom.Text.Trim() == "" || txtPrenom.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtTelephone.Text.Trim() == "")
                {
                    MessageBox.Show("Fill in the fields");
                }
                else
                {
                    SqlCommand query = new SqlCommand($"SELECT COUNT(*) FROM [USER] WHERE email = '{txtEmail.Text}'",
                                                        Program.MyConnection());
                    int emailCheck = (int)query.ExecuteScalar();
                    if (emailCheck == 0)
                    {
                        SqlCommand insert = new SqlCommand($"INSERT INTO [USER](nom, prenom, type, email, password, is_active, telephone) VALUES('{txtNom.Text}', '{txtPrenom.Text}', '{type}', '{txtEmail.Text}', '{txtPass.Text}', {is_active}, '{txtTelephone.Text}')",
                                                            Program.MyConnection());
                        int insertCheck = (int)insert.ExecuteNonQuery();
                        if (insertCheck != 0)
                        {
                            MessageBox.Show("Added with success");
                            new FrmUser().Show();
                            Close();
                        }
                        else
                            MessageBox.Show("The user isn't added");
                    }
                    else
                        MessageBox.Show("Email already exist !!");
                }
            }
            else
                MessageBox.Show("Password incorrect !");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new FrmUser().Show();
            Close();
        }
    }
}
