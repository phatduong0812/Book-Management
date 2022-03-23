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

namespace PEApp
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

        public Employee GetEmployee()
        {
            Employee employee = new Employee()
            {
                EmployeeId = txtEmId.Text,
                EmployeeName = txtEmName.Text,
                YearOfBirth = int.Parse(txtYob.Text),
                DepartmentName = txtDeName.Text,
                JobTitleId = txtJobId.Text
            };
            return employee;
        }

        public List<Employee> LoadListEm()
        {
            var list = employeeRepository.GetLists();
            return list;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            source = new BindingSource();
            var lists = LoadListEm().ToList();
            source.DataSource = lists;

            txtEmId.Enabled = false;
            txtEmName.Enabled = false;
            txtYob.Enabled = false;
            txtDeName.Enabled = false;
            txtJobId.Enabled = false;

            txtEmId.DataBindings.Clear();
            txtEmName.DataBindings.Clear();
            txtYob.DataBindings.Clear();
            txtDeName.DataBindings.Clear();
            txtJobId.DataBindings.Clear();

            txtEmId.DataBindings.Add("Text", source, "EmployeeId");
            txtEmName.DataBindings.Add("Text", source, "EmployeeName");
            txtYob.DataBindings.Add("Text", source, "YearOfBirth");
            txtDeName.DataBindings.Add("Text", source, "DepartmentName");
            txtJobId.DataBindings.Add("Text", source, "JobTitleId");

            if (lists.Count() == 0)
            {
                ClearText();
                btDelete.Enabled = false;
            }
            else
            {
                btDelete.Enabled = true;
            }

            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeDetails employee = new EmployeeDetails()
            {
                InsertOrUpdate = true,
                employee = GetEmployee(),
                employeeRepository = employeeRepository
            };
            employee.ShowDialog();
            LoadListEm();
        }
    }
}
