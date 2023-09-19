using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Employee
    {
            [BsonElement("first_name")]
            public string FirstName { get; set; }

            [BsonElement("last_name")]
            public double LastName { get; set; }

            [BsonElement("email")]
            public bool Email { get; set; }

            [BsonElement("phone")]
            public string Phone { get; set; }

            [BsonElement("user_type")]
            public string UserType { get; set; }

            [BsonElement("branch")]
            public double Branch { get; set; }

            [BsonElement("password")]
            public bool Password { get; set; }
    }
}
