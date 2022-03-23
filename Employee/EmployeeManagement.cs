using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
      }

        BindingSource source;

        public IEmployeeRepository employeeRepository = new EmployeeRepository();

        private void ClearText()
        {
            txtEmId.Text = string.Empty;
            txtEmName.Text = string.Empty;
            txtYob.Text = string.Empty;
            txtDeName.Text = string.Empty;
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            btDelete.Enabled = false;
        }

        
    }
}
