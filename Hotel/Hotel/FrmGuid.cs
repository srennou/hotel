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
    public partial class FrmGuid : Form
    {
        public FrmGuid()
        {
            InitializeComponent();
        }

        private void FrmGuid_Load(object sender, EventArgs e)
        {
            remp();
        }
        public void remp()
        {
            DataTable tables = new DataTable();

            SqlCommand querys = new SqlCommand($"SELECT nom, prenom, email, telephone FROM [GUID]", Program.MyConnection());
            SqlDataReader reads = querys.ExecuteReader();
            tables.Load(reads);
            dgvGuid.DataSource = tables;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new FrmAddGuid().Show();
            Close();
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            if (dgvGuid.CurrentRow != null)
            {
                string message = "Are you sure";
                string caption = "Delete user";

                string value = dgvGuid.CurrentRow.Cells[2].Value.ToString();
                var check = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand($"DELETE FROM [GUID] WHERE email LIKE '{value}' ",
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
            if (dgvGuid.CurrentRow != null)
            {
                string value = dgvGuid.CurrentRow.Cells[2].Value.ToString();
                FrmUpdateGuid myForm = new FrmUpdateGuid();
                myForm.txtNom.Text = dgvGuid.CurrentRow.Cells[0].Value.ToString();
                myForm.txtPrenom.Text = dgvGuid.CurrentRow.Cells[1].Value.ToString();
                myForm.txtEmail.Text = dgvGuid.CurrentRow.Cells[2].Value.ToString();
                myForm.txtTelephone.Text = dgvGuid.CurrentRow.Cells[3].Value.ToString();
                myForm.lblUnique.Text = dgvGuid.CurrentRow.Cells[2].Value.ToString();
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
