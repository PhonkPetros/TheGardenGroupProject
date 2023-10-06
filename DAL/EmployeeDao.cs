using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Driver;

namespace DAL
{
    public class EmployeeDao : DAO
    {
        public Employee GetEmployeeByEmail(string email)
        {
            return employeeCollection.Find(e => e.Email == email).FirstOrDefault();
        }
    }
}
