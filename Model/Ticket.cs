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
        private ObjectId id;

        [BsonElement("date_reported")]
        private DateTime date_reported;

        [BsonElement("subject")]
        private string subject;

        [BsonElement("incident_type")]
        private string incident_type;

        [BsonElement("reported_by")]
        private string reported_by;

        [BsonElement("priority")]
        private string priority;

        [BsonElement("deadline")]
        private DateTime deadline;

        [BsonElement("description")]
        private string description;

        [BsonElement("status")]
        private string status;

        [BsonIgnore]
        public ObjectId Id
        {
            get { return id; }
            set { id = value; }
        }
        [BsonIgnore]
        public DateTime DateReported
        {
            get { return date_reported; }
            set { date_reported = value; }
        }
        [BsonIgnore]
        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
        [BsonIgnore]
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        [BsonIgnore]
        public IncidentType IncidentType //?
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
            set
            {
                incident_type = value.ToString();
            }


        }
        [BsonIgnore]
        public string ReportedBy
        {
            get { return reported_by; }
            set {  reported_by = value; }
        }
        [BsonIgnore]
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
            set { priority = value.ToString(); }

        }
        [BsonIgnore]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [BsonIgnore]
        public Status Status //?
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
            set
            {
                status = value.ToString();
            }
        }

        public Ticket(ObjectId id, DateTime date_reported, string subject, IncidentType incident_type, string reported_by, Priority priority, DateTime deadline, string description, Status status)
        {
            this.id = id;
            this.date_reported = date_reported;
            this.subject = subject;
            this.incident_type = incident_type.ToString();
            this.reported_by = reported_by;
            this.priority = priority.ToString();
            this.deadline = deadline;
            this.description = description;
            this.status = status.ToString();
        }

        public Ticket()
        {

        }
    }
}
