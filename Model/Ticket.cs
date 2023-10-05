using System;
using Model.Enums;
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
        private string reported_by;

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
            get 
            { 
                    if (IncidentType.TryParse(incident_type, out IncidentType result))
                    {
                        return result;
                    }
                    else
                    {
                    return IncidentType.Service;
                    }
            }
        }

        public string ReportedBy
        {
            get { return reported_by; }
        }

        public Priority Priority
        {
            get 
            { 
                if (Priority.TryParse(priority, out Priority result))
                {
                    return result;
                }
                else
                {
                    return Priority.Low;
                }
            }
        }

        public string Description
        {
            get { return description; }
        }

        public Status Status
        {
            get 
            {
                if (Status.TryParse(status, out Status result))
                {
                    return result;
                }
                else
                {
                    return Status.Open;
                }
            }
        }

        public Ticket(string id, DateTime date_reported, string subject, IncidentType incident_type, string reported_by, Priority priority, DateTime deadline, string description, Status status)
        {
            this.id = id;
            this.date_reported = date_reported.ToString();
            this.subject = subject;
            this.incident_type = incident_type.ToString();
            this.reported_by = reported_by;
            this.priority = priority.ToString();
            Deadline = deadline;
            this.description = description;
            this.status = status.ToString();
        }
    }
}
