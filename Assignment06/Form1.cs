using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void btnAddMaj_Click(object sender, EventArgs e)
        {
            AddMajor addMajor = new AddMajor();
            addMajor.ShowDialog();
        }

        private void btnViewStu_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent();
            viewStudent.ShowDialog();
        }

        private void btnViewMaj_Click(object sender, EventArgs e)
        {
            ViewMajor viewMajor = new ViewMajor();
            viewMajor.ShowDialog();
        }
    }
}
