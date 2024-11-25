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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private string connectionString = @"server=(localdb)\MSSQLLocalDB;database=Dominican;Trusted_connection=true";

        private void AddStudent_Load(object sender, EventArgs e)
        {
            PopulateMajorComboBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text) || cbMajor.SelectedItem == null)
            {
                MessageBox.Show("Please enter all details.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO dbo.Student (FirstName, LastName, Major) VALUES (@FirstName, @LastName, @Major)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", tbFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", tbLastName.Text);
                        cmd.Parameters.AddWithValue("@Major", cbMajor.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Student saved successfully!");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in student saving: " + ex.Message);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PopulateMajorComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT Major FROM dbo.Major";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbMajor.Items.Add(reader["Major"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading majors: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            cbMajor.SelectedIndex = -1;
        }

    }
}
