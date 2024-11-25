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

namespace Assignment06
{
    public partial class ViewMajor : Form
    {
        public ViewMajor()
        {
            InitializeComponent();
        }

        private string connectionString = @"server=(localdb)\MSSQLLocalDB;database=School;Trusted_connection=true";


        private void ViewMajor_Load(object sender, EventArgs e)
        {
            LoadMajors();
        }

        private void LoadMajors()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM dbo.Major";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvMajor.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading majors: " + ex.Message);
                }
            }
        }
    }
}
