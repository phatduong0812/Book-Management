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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public IDBAccountRepository dBAccountRepository = new DBAccountRepository();

        private void btLogin_Click(object sender, EventArgs e)
        {
            var id = txtAccountId.Text;
            var password = txtPassword.Text;

            Dbaccount account = dBAccountRepository.Login(id, password);
            if (account == null)
            {
                MessageBox.Show("You are not allowed to access this function!");
            }
            else
            {
                if (account.AccountRole == 1)
                {
                    EmployeeManagement employee = new EmployeeManagement();
                    this.Hide();
                    employee.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("You are not allowed to access this function", "Login");
                }
            }
        }
    }
}
