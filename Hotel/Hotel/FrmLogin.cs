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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand($"SELECT COUNT(*) FROM [USER] WHERE email = '{txtEmail.Text}' AND password = '{txtPass.Text}' ",
                                                   Program.MyConnection());
            int checkEmailPass = (int)query.ExecuteScalar();

            if (checkEmailPass == 1)
            {
                SqlCommand secondQuery = new SqlCommand($"SELECT COUNT(*) FROM [USER] WHERE email = '{txtEmail.Text}' AND password = '{txtPass.Text}' AND is_active = 1",
                                                        Program.MyConnection());
                int checkActive = (int)secondQuery.ExecuteScalar();
                if (checkActive == 1)
                {
                    SqlCommand thirdQuery = new SqlCommand($"SELECT COUNT(*) FROM [USER] WHERE email = '{txtEmail.Text}' AND password = '{txtPass.Text}' AND is_active = 1 AND type = 'admin'",
                                                        Program.MyConnection());
                    int checkAdmin = (int)thirdQuery.ExecuteScalar();
                    if (checkAdmin == 1)
                    {
                        new FrmEspaceAdmin().Show();
                        Hide();
                    }
                    else
                    {
                        new FrmEspaceUser().Show();
                        Hide();
                    }
                }
                else
                    MessageBox.Show("This account isn't Active");
            }
            else
                MessageBox.Show("Wrong Email or Password");
        }
    }
}
