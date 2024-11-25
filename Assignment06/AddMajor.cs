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
    public partial class AddMajor : Form
    {
        public AddMajor()
        {
            InitializeComponent();
        }

        private string connectionString = @"server=(localdb)\MSSQLLocalDB;database=Dominican;Trusted_connection=true";

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaj.Text))
            {
                MessageBox.Show("Please enter the major name.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO dbo.Major (Major) VALUES (@Major)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Major", tbMaj.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Major saved successfully!");
                    tbMaj.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving major: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
