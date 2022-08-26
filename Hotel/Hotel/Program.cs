using System.Data;
using System.Data.SqlClient;

namespace Hotel
{
    internal static class Program
    {
        private static SqlConnection Instance;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }

        public static SqlConnection MyConnection()
        {
            if (Instance == null)
            {
                Instance = new SqlConnection(@"Server =WHITEDRAGON\MYSERVER; database = hope4; integrated security = true");
                Instance.Open();
            }
            if (Instance.State == ConnectionState.Closed)
            {
                Instance.Open();
            }
            return Instance;
        }
        public static void Rempcb(String dd,String nom,String val,ComboBox cb)
        {
            SqlCommand query = new SqlCommand(dd, MyConnection());
            SqlDataReader read = query.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            cb.DataSource=table;
            cb.DisplayMember=nom;
            cb.ValueMember=val;
            read.Close();
        }

        internal static SqlConnection SeConnecter()
        {
            throw new NotImplementedException();
        }
    }
}