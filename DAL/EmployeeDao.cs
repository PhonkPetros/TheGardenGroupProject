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

        public string GetUserId(string userName)
        {
            string[] nameParts = userName.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            FilterDefinition<Employee> filter = Builders<Employee>.Filter.And(
                Builders<Employee>.Filter.Eq("first_name", firstName),
                Builders<Employee>.Filter.Eq("last_name", lastName)
                );
            
            Employee employee =  employeeCollection.Find(filter).FirstOrDefault();
            return employee.Id.ToString();
        }

        public string GetUserName(string id)
        {
            FilterDefinition<Employee> filter = Builders<Employee>.Filter.Eq("_id", ObjectId.Parse(id));
            Employee user = employeeCollection.Find(filter).FirstOrDefault();
            return user.FullName;
        }
    }
}
