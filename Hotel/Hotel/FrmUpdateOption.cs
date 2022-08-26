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
    public partial class FrmUpdateOption : Form
    {
        public FrmUpdateOption()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = lblUnique2.Text;
            if (txtPrix.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [OPTION] SET prix_option = {txtPrix.Text} WHERE nom_option LIKE '{value}' ",
                                                        Program.MyConnection());
                decimal updateCheck = (decimal)update.ExecuteNonQuery();
            }
            if (txtNom.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [OPTION] SET nom_option = '{txtNom.Text}' WHERE nom_option LIKE '{value}' ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            new FrmOption().Show();
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            new FrmOption().Show();
            Close();
        }
    }
}
