using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBAccountDAO
    {
        private static DBAccountDAO instance = null;
        private static readonly object instanceLock = new object();

        private DBAccountDAO() { }

        public static DBAccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DBAccountDAO();
                    }
                    return instance;
                }
            }
        }

        public Dbaccount Login(string accountID, string password)
        {
            EmployeeJobTitleContext context = new EmployeeJobTitleContext();
            var dbAccount = context.Dbaccounts.FirstOrDefault(x => x.AccountId == accountID && x.AccountPassword == password);
            return dbAccount;
        }
    }
}
