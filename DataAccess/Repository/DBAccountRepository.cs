using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class DBAccountRepository : IDBAccountRepository
    {
        public Dbaccount Login(string id, string password) => DBAccountDAO.Instance.Login(id, password);
    }
}
