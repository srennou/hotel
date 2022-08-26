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
    public partial class FrmUser : Form
    {
        private String value;

        public FrmUser()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new FrmAddUser().Show();
            Hide();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            remp();
        }
        public void remp()
        {
            DataTable tables = new DataTable();

            SqlCommand querys = new SqlCommand($"SELECT nom, prenom, email, type, telephone, is_active FROM [USER]", Program.MyConnection());
            SqlDataReader reads = querys.ExecuteReader();
            tables.Load(reads);
            dgvUser.DataSource = tables;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow != null)
            {
                string value = dgvUser.CurrentRow.Cells[2].Value.ToString();
                FrmUpdateUser myForm = new FrmUpdateUser();
                myForm.txtNom.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
                myForm.txtPrenom.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
                myForm.txtEmail.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
                myForm.txtTelephone.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
                myForm.lblUnique.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
                myForm.Show();
                Hide();
            }
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow != null)
            {
                string message = "Are you sure";
                string caption = "Delete user";

                string value = dgvUser.CurrentRow.Cells[2].Value.ToString();
                var check = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand($"DELETE FROM [USER] WHERE email LIKE '{value}' ",
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

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            new FrmEspaceAdmin().Show();
            Close();
        }
    }
}
