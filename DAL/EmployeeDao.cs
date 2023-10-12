using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class EmployeeDao : DAO
    {
        public Employee GetEmployeeByEmail(string email)
        {
            return employeeCollection.Find(e => e.Email == email).FirstOrDefault();
        }

        public List<Employee> GetEmployees()
        {
            FilterDefinition<Employee> filter = Builders<Employee>.Filter.Empty;
            return (List<Employee>)employeeCollection.Find(filter).ToList();
        }
    }
}
