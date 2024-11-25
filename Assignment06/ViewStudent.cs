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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private string connectionString = @"server=(localdb)\MSSQLLocalDB;database=Dominican;Trusted_connection=true";

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM dbo.Student";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvStudent.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }

    }
}
