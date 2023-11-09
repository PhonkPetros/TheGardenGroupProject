using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class EmployeeController
    {
        private readonly EmployeeDao dao;
        public EmployeeController()
        {
            dao = new EmployeeDao();
        }
        public List<Employee> GetEmployees()
        {
            return dao.GetEmployees();
        }

        public string GetUserId(string userName)
        {
            return dao.GetUserId(userName);
        }

        public string GetUserName(string id)
        {
            return dao.GetUserName(id);
        }

        public bool UpdateEmployeePassword(string email, string newPassword)
        {
            return dao.UpdateEmployeePassword(email, newPassword);
        }
    }
}
