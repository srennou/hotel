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
    public partial class FrmReservation : Form
    { 
        public static double total;
        public FrmReservation()
        {
            InitializeComponent();
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            DataTable tables = new DataTable();
            SqlCommand querys = new SqlCommand($"SELECT id_chambre, nom_chambre FROM type_chambre", Program.MyConnection());
            SqlDataReader reads = querys.ExecuteReader();
            tables.Load(reads);
            cbxType.DataSource = tables;
            cbxType.DisplayMember = "nom_chambre";
            cbxType.ValueMember = "id_chambre";
            cbxType.SelectedItem = 0;
            //String vv = $"select c.num_chambre,t.prix from chambre c , type_chambre t where c.id_chambre = t.id_chambre and t.id_chambre={cbxType.SelectedValue}";
            remp();
        }
        //String ss=$"SELECT num_chambre AS Nombre,nom_chambre AS Type, prix AS Prix, telcham AS Telephone FROM [CHAMBRE] c, [TYPE_CHAMBRE] t WHERE c.id_chambre = t.id_chambre";
        public void remp()
        {
            DataTable tables = new DataTable();
            SqlCommand querys = new SqlCommand("proccham", Program.MyConnection());
            querys.CommandType = CommandType.StoredProcedure;
            querys.Parameters.AddWithValue("@dd", SqlDbType.Date).Value = dtpStart.Value;
            querys.Parameters.AddWithValue("@df", SqlDbType.Date).Value = dtpEnd.Value;
            SqlDataReader reads = querys.ExecuteReader();
            tables.Load(reads);
            dgvChambre.DataSource = tables;
        }

        private void cbxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String vv = $"select c.num_chambre, t.prix from chambre c , type_chambre t where c.id_chambre = t.id_chambre and t.id_chambre = {cbxType.SelectedValue}";

            //remp(vv);
        }

        private void dgvOption_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e, dtpStart);
        }

        private void btnAdd_Click(object sender, EventArgs e, DateTimePicker dtpStart)
        {
            FrmResult myForm = new FrmResult();
            total = 0;
            DateTime startDate;
            DateTime endDate;
            int totalDate;
            if (dgvChambre.CurrentRow != null)
            {
                double chambrePrice = (double)dgvChambre.CurrentRow.Cells[1].Value;
                startDate = dtpStart.Value;
                endDate = dtpEnd.Value;
                totalDate = (endDate - startDate).Days + 1;
                chambrePrice *= totalDate;
                total += chambrePrice;
            }
            if (cbxGuid.Checked)
            {
                total += 99.99;
                myForm.cbxGuid.Checked = true;
            }
            if (cbxMassage.Checked)
            {
                total += 199.99;
                myForm.cbxMassage.Checked = true;
            }
            if (cbxDinner.Checked)
            {
                total += 499.99;
                myForm.cbxDinner.Checked = true;
            }
            myForm.txtCIN.Text = txtCIN.Text;
            myForm.txtNom.Text = txtNom.Text;
            myForm.txtPrenom.Text = txtPrenom.Text;
            myForm.txtType.Text = dgvChambre.CurrentRow.Cells[1].Value.ToString();
            myForm.txtNum.Text = dgvChambre.CurrentRow.Cells[0].Value.ToString();
            myForm.txtDateDebut.Text = dtpStart.Value.ToString("yyyy-MM-dd");
            myForm.txtDatefin.Text = dtpEnd.Value.ToString("yyyy-MM-dd");
            myForm.txtTotal.Text = total.ToString();
            myForm.ShowDialog();
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            new FrmEspaceUser().Show();
            Close();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            remp();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            remp();
        }
    }
}
