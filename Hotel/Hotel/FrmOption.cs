using System.Data;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
        }
        public void remp()
        {
            DataTable tables = new DataTable();

            SqlCommand querys = new SqlCommand($"SELECT nom_option AS nom, prix_option AS prix FROM [OPTION]", Program.MyConnection());
            SqlDataReader reads = querys.ExecuteReader();
            tables.Load(reads);
            dgvOption.DataSource = tables;
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {
            remp();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new FrmAddOption().Show();
            Close();
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            if (dgvOption.CurrentRow != null)
            {
                string message = "Are you sure";
                string caption = "Delete option";

                string value = dgvOption.CurrentRow.Cells[0].Value.ToString();
                var check = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand($"DELETE FROM [OPTION] WHERE nom_option LIKE '{value}' ",
                                                        Program.MyConnection());
                    int deleteCheck = (int)delete.ExecuteNonQuery();
                    if (deleteCheck != 0)
                    {
                        MessageBox.Show("Deleted with success");
                        remp();
                    }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvOption.CurrentRow != null)
            {
                string value = dgvOption.CurrentRow.Cells[0].Value.ToString();
                FrmUpdateOption myForm = new FrmUpdateOption();
                myForm.txtNom.Text = dgvOption.CurrentRow.Cells[0].Value.ToString();
                myForm.txtPrix.Text = dgvOption.CurrentRow.Cells[1].Value.ToString();
                myForm.lblUnique2.Text = dgvOption.CurrentRow.Cells[0].Value.ToString();
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

