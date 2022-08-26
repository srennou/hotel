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
    public partial class FrmClients : Form
    {
        public FrmClients()
        {
            InitializeComponent();
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            remp();
        }
        public void remp()
        {
            DataTable tables = new DataTable();

            SqlCommand querys = new SqlCommand($"SELECT * FROM client", Program.MyConnection());
            SqlDataReader reads = querys.ExecuteReader();
            tables.Load(reads);
            dgvClient.DataSource = tables;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new FrmAddClient().Show();
            Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow != null)
            {
                FrmUpdateClient myForm = new FrmUpdateClient();
                myForm.txtCIN.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
                myForm.txtNom.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
                myForm.txtPrenom.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
                myForm.txtAdresse.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
                myForm.txtEmail.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
                myForm.txtTelephone.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();
                myForm.Show();
                Hide();
            }
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow != null)
            {
                string message = "Are you sure";
                string caption = "Delete user";

                string cin = dgvClient.CurrentRow.Cells[0].Value.ToString();
                var check = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand($"DELETE FROM client WHERE cin LIKE '{cin}' ",
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCIN.Text == "")
                remp();
            else
            {
                DataTable tables = new DataTable();
                SqlCommand querys = new SqlCommand($"SELECT * FROM client WHERE cin = '{txtCIN.Text}'", Program.MyConnection());
                SqlDataReader reads = querys.ExecuteReader();
                tables.Load(reads);
                dgvClient.DataSource = tables;
            }

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            FrmReservation myForm = new FrmReservation();
            myForm.txtCIN.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
            myForm.txtNom.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            myForm.txtPrenom.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            myForm.Show();
            Hide();
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            new FrmEspaceUser().Show();
            Close();
        }
    }
}
