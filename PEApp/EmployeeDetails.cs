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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        public Employee employee { get; set; }

        public IEmployeeRepository employeeRepository { get; set; }
        public IJobTitleRepository jobTitleRepository = new JobTitleRepository();
        public bool InsertOrUpdate;
        List<JobTitle> jobTitles = new List<JobTitle>();

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            
            jobTitles = jobTitleRepository.GetJobTitles();
            cbJobId.DropDownStyle = ComboBoxStyle.DropDownList;
            jobTitles.ForEach(p => cbJobId.Items.Add(p.JobTitleId));
            if (InsertOrUpdate)
            {

                txtEmId.Text = employee.EmployeeId;
                txtEmName.Text = employee.EmployeeName;
                txtYob.Text = employee.YearOfBirth.ToString();
                txtDeName.Text = employee.DepartmentName;
                var index = jobTitles.FindIndex(x => x.JobTitleId == employee.JobTitleId);
                cbJobId.SelectedIndex = index;
            }
            else
            {
                cbJobId.SelectedIndex = 0;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Employee newEm = new Employee();
            newEm.EmployeeId = employee.EmployeeId;
            newEm.EmployeeName = employee.EmployeeName;
            newEm.YearOfBirth = employee.YearOfBirth;
            newEm.DepartmentName = employee.DepartmentName;
            newEm.JobTitleId = jobTitles.ElementAt(cbJobId.SelectedIndex).JobTitleId;
            if (InsertOrUpdate)
            {
                employeeRepository.Update(newEm);
                MessageBox.Show("Update successfully");
                Close();
            }
            else
            {
                employeeRepository.Add(newEm);
                MessageBox.Show("Add successfully");
                Close();
            }
        }
    }
}
