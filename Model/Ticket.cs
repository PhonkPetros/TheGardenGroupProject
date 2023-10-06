using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string id;

        [BsonElement("date_reported")]
        private string date_reported;


        [BsonElement("subject")]
        private string subject;

        [BsonElement("incident_type")]
        private string incident_type;

        [BsonElement("reported_by")]
        private Employee reported_by;

        [BsonElement("priority")]
        private string priority;

        [BsonElement("deadline")]
        private string deadline;

        [BsonElement("description")]
        private string description;

        [BsonElement("status")]
        private string status;

        public string Id
        {
            get { return id; }
        }

        public DateTime DateReported
        {
            get
            {
                if (DateTime.TryParseExact(date_reported, "yyyy-MM-dd HH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime result))
                {
                    return result;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }

        public DateTime Deadline
        {
            get
            {
                if (DateTime.TryParseExact(deadline, "yyyy-MM-dd HH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime result))
                {
                    return result;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                deadline = value.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        public string Subject
        {
            get { return subject; }
        }

        public IncidentType IncidentType
        {
            get { return incident_type; }
        }

        public Employee ReportedBy
        {
            get { return reported_by; }
        }
        //hello

        public string Priority
        {
            get { return priority; }
        }

        public string Description
        {
            get { return description; }
        }

        public string Status
        {
            get { return status; }
        }
    }
}
