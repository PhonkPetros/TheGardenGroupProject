using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class AuthenticationLogic
    {
        private EmployeeDao employeeDao;

        public AuthenticationLogic()
        {
            employeeDao = new EmployeeDao();
        }

        public Employee GetEmployeeByEmail(string email)
        {
            return employeeDao.GetEmployeeByEmail(email);
        }

        public Employee AuthenticateUser(string email, string password)
        {
            Employee employee = employeeDao.GetEmployeeByEmail(email);

            if (employee != null)
            {
                if (employee.Password == password)
                {
                    return employee;
                }
            }

            return null;
        }
    }
}
