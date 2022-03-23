using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JobTitleDAO
    {
        private static JobTitleDAO instance = null;
        private static readonly object instanceLock = new object();

        private JobTitleDAO() { }

        public static JobTitleDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new JobTitleDAO();
                    }
                    return instance;
                }
            }
        }

        public List<JobTitle> GetJobTitles()
        {
            EmployeeJobTitleContext context = new EmployeeJobTitleContext();
            var list = context.JobTitles.ToList();
            return list;
        }
    }
}
