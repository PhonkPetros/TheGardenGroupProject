using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    internal class Ticket
    {
        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("date_reported")]
        public DateTime DateReported { get; set; }

        [BsonElement("subject")]
        public string subject { get; set; }

        [BsonElement("incident_type")]
        public string incidentType { get; set; } //change to enumeration

        /*
        [BsonElement("reported_by")]
        public User reportedBy {get; set;}
        */

        [BsonElement("priority")]
        public string priority { get; set; } // change to enum

        [BsonElement("deadline")]
        public DateTime deadline { get; set; }

        [BsonElement("description")]
        public string description { get; set; }

        [BsonElement("status")]
        public string status { get; set; } //change to enum

    }
}
