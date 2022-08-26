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
    public partial class FrmAddGuid : Form
    {
        public FrmAddGuid()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == "" || txtPrenom.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtTelephone.Text.Trim() == "")
            {
                MessageBox.Show("Fill in the fields");
            }
            else
            {
                SqlCommand insert = new SqlCommand($"INSERT INTO [GUID](id_option, nom, prenom, email, telephone) VALUES(2, '{txtNom.Text}', '{txtPrenom.Text}', '{txtEmail.Text}', '{txtTelephone.Text}')",
                                                            Program.MyConnection());
                int insertCheck = (int)insert.ExecuteNonQuery();
                if (insertCheck != 0)
                {
                    MessageBox.Show("Added with success");
                    new FrmGuid().Show();
                    Close();
                }
                else
                    MessageBox.Show("The guid isn't added");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new FrmGuid().Show();
            Close();
        }
    }
}
