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
    public partial class FrmAddOption : Form
    {
        public FrmAddOption()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == "" || txtPrix.Text.Trim() == "")
            {
                MessageBox.Show("Fill in the fields");
            }
            else
            {
                SqlCommand insert = new SqlCommand($"INSERT INTO [OPTION](nom_option, prix_option) VALUES('{txtNom.Text}', {txtPrix.Text})",
                                                            Program.MyConnection());
                decimal insertCheck = (decimal)insert.ExecuteNonQuery();
                if (insertCheck != 0)
                {
                    MessageBox.Show("Added with success");
                    new FrmOption().Show();
                    Close();
                }
                else
                    MessageBox.Show("The option isn't added");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            new FrmOption().Show();
            Close();
        }
    }
}
