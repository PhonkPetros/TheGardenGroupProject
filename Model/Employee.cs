using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Employee
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("first_name")]
        public string FirstName { get; set; }

        [BsonElement("last_name")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("user_type")]
        private string user_type;

        [BsonIgnore]
        public UserType UserType
        {
            get
            {
                if (UserType.TryParse(user_type, out UserType result))
                {
                    return result;
                }
                else
                {
                    return UserType.Employee;
                }
            }
            set
            {
                user_type = value.ToString();
            }
        }

        [BsonElement("branch")]
        public string Branch { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonIgnore]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

    }
}
