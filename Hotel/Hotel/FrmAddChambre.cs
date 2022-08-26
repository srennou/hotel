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
    public partial class FrmAddChambre : Form
    {
        public FrmAddChambre()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Trim() == "" || txtTelephone.Text.Trim() == "")
            {
                MessageBox.Show("Fill in the fields");
            }
            else
            {
                SqlCommand insert = new SqlCommand($"INSERT INTO [chambre](num_chambre, telcham, id_chambre) VALUES({txtNum.Text}, '{txtTelephone.Text}', {cbxType.SelectedValue})",
                                                            Program.MyConnection());
                int insertCheck = (int)insert.ExecuteNonQuery();
                if (insertCheck != 0)
                {
                    MessageBox.Show("Added with success");
                    new FrmChambre().Show();
                    Close();
                }
                else
                    MessageBox.Show("The room isn't added");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new FrmChambre().Show();
            Close();
        }

        private void FrmAddChambre_Load(object sender, EventArgs e)
        {
            DataTable tables = new DataTable();

            SqlCommand querys = new SqlCommand($"SELECT id_chambre, nom_chambre FROM type_chambre", Program.MyConnection());
            SqlDataReader reads = querys.ExecuteReader();
            tables.Load(reads);
            cbxType.DataSource = tables;
            cbxType.DisplayMember = "nom_chambre";
            cbxType.ValueMember = "id_chambre";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
