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
    public partial class FrmUpdateChambre : Form
    {
        public FrmUpdateChambre()
        {
            InitializeComponent();
        }

        private void FrmUpdateChambre_Load(object sender, EventArgs e)
        {
            DataTable tables = new DataTable();

            SqlCommand querys = new SqlCommand($"SELECT id_chambre, nom_chambre FROM type_chambre", Program.MyConnection());
            SqlDataReader reads = querys.ExecuteReader();
            tables.Load(reads);
            cbxType.DataSource = tables;
            cbxType.DisplayMember = "nom_chambre";
            cbxType.ValueMember = "id_chambre";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var value = lblUnique3.Text;

            SqlCommand firstUpdate = new SqlCommand($"UPDATE [CHAMBRE] SET id_chambre = {cbxType.SelectedValue} WHERE num_chambre LIKE {value}",
                                                        Program.MyConnection());
            int firstUpdateCheck = (int)firstUpdate.ExecuteNonQuery();
            if (txtTelephone.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [CHAMBRE] SET telcham = '{txtTelephone.Text}' WHERE num_chambre LIKE {value} ",
                                                        Program.MyConnection());
                int updateCheck = (int)update.ExecuteNonQuery();
            }
            if (txtPrix.Text.Trim() != "")
            {
                SqlCommand update = new SqlCommand($"UPDATE [TYPE_CHAMBRE] SET prix = {txtPrix.Text} WHERE id_chambre LIKE {cbxType.SelectedValue} ",
                                                        Program.MyConnection());
                decimal updateCheck = (decimal)update.ExecuteNonQuery();
            }
            new FrmChambre().Show();
            Close();
        }
    }
}
