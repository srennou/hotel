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
    public partial class FrmChambre : Form
    {
        public FrmChambre()
        {
            InitializeComponent();
        }

        private void FrmChambre_Load(object sender, EventArgs e)
        {
            remp();
        }
        public void remp()
        {
            DataTable tables = new DataTable();

            SqlCommand querys = new SqlCommand($"SELECT num_chambre AS Nombre,nom_chambre AS Type, prix AS Prix, telcham AS Telephone FROM [CHAMBRE] c, [TYPE_CHAMBRE] t WHERE c.id_chambre = t.id_chambre", Program.MyConnection());
            SqlDataReader reads = querys.ExecuteReader();
            tables.Load(reads);
            dgvChambre.DataSource = tables;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new FrmAddChambre().Show();
            Close();
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            if (dgvChambre.CurrentRow != null)
            {
                string message = "Are you sure";
                string caption = "Delete option";

                string value = dgvChambre.CurrentRow.Cells[0].Value.ToString();
                var check = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand($"DELETE FROM [CHAMBRE] WHERE num_chambre LIKE '{value}' ",
                                                        Program.MyConnection());
                    int deleteCheck = (int)delete.ExecuteNonQuery();
                    if (deleteCheck != 0)
                    {
                        remp();
                        MessageBox.Show("Deleted with success");
                    }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvChambre.CurrentRow != null)
            {
                FrmUpdateChambre myForm = new FrmUpdateChambre();
                myForm.txtTelephone.Text = dgvChambre.CurrentRow.Cells[3].Value.ToString();
                myForm.lblUnique3.Text = dgvChambre.CurrentRow.Cells[0].Value.ToString();
                myForm.Show();
                Hide();
            }
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            new FrmEspaceAdmin().Show();
            Close();
        }
    }
}
