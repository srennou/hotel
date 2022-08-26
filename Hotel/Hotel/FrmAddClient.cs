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
    public partial class FrmAddClient : Form
    {
        public FrmAddClient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sexe = "Homme";
            if (rbnFemme.Checked)
                sexe = rbnFemme.Text;
            if (txtCIN.Text.Trim() == "" || txtNom.Text.Trim() == "" || txtPrenom.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtTelephone.Text.Trim() == "" || txtAdresse.Text.Trim() == "")
            {
                MessageBox.Show("Fill in the fields");
            }
            else
            {
                SqlCommand query = new SqlCommand($"SELECT COUNT(*) FROM client WHERE email = '{txtEmail.Text}'",
                                                        Program.MyConnection());
                int emailCheck = (int)query.ExecuteScalar();
                SqlCommand secondQuery = new SqlCommand($"SELECT COUNT(*) FROM client WHERE cin = '{txtCIN.Text}'",
                                                        Program.MyConnection());
                int cinCheck = (int)secondQuery.ExecuteScalar();
                if (emailCheck == 0 || cinCheck == 0)
                {
                    SqlCommand insert = new SqlCommand($"INSERT INTO client(cin, nom, prenom, email, adresse, telephone, sexe) VALUES('{txtCIN.Text}', '{txtNom.Text}', '{txtPrenom.Text}', '{txtEmail.Text}', '{txtAdresse.Text}', '{txtTelephone.Text}', '{sexe}')",
                                                        Program.MyConnection());
                    int insertCheck = (int)insert.ExecuteNonQuery();
                    if (insertCheck != 0)
                    {
                        MessageBox.Show("Added with success");
                        FrmReservation myForm = new FrmReservation();
                        myForm.txtCIN.Text = txtCIN.Text;
                        myForm.txtNom.Text = txtNom.Text;
                        myForm.txtPrenom.Text = txtPrenom.Text;
                        myForm.Show();
                        Hide();
                    }
                    else
                        MessageBox.Show("The Client isn't added");
                }
                else
                    MessageBox.Show("Email or CIN already exist !!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new FrmEspaceUser().Show();
            Close();
        }
    }
}
