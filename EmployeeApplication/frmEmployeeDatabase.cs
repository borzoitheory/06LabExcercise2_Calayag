using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNameSpace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text;
            string empFirstName = txtFirstName.Text;
            string empLastName = txtLastName.Text;
            string empPosition = txtPosition.Text;

            Employee emp = new Employee(id, empFirstName, empLastName, empPosition);

            dataGridView1.Rows.Add(emp.EmployeeID, emp.EmployeeFirstName, emp.EmployeeLastName, emp.EmployeePosition);
        }
    }
}
