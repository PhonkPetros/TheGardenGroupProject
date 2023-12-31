﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Model;
using Model.Enums;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDAO : DAO
    {
        public void CreateNewTicket(Ticket newTicket)
        {
            ticketCollection.InsertOne(newTicket);
        }

        public List<Ticket> GetTicketsWithDeadlines(Employee employee)
        {
            var startOfCurrentDayUtc = DateTime.UtcNow.Date;
            List<BsonDocument> pipeline;

            if (employee.UserType == UserType.ServiceDeskEmployee || employee.UserType == UserType.IcidentEmployee)
            {
                var match = new BsonDocument
                {
                    { "$match", new BsonDocument { { "deadline", new BsonDocument { { "$gte", startOfCurrentDayUtc } } } } }
                };

                pipeline = new List<BsonDocument> { match };
            }
            else
            {
                var match = new BsonDocument
                {
                    { "$match", new BsonDocument
                        {
                            { "deadline", new BsonDocument { { "$gte", startOfCurrentDayUtc } } },
                            { "reported_by", employee.Id }
                        }
                    }
                };

                pipeline = new List<BsonDocument> { match };
            }

            var lookup = new BsonDocument
            {
                { "$lookup", new BsonDocument
                    {
                        { "from", "employees" },
                        { "localField", "reported_by" },
                        { "foreignField", "_id" },
                        { "as", "employeeInfo" }
                    }
                }
            };
            pipeline.Add(lookup);

            var unwind = new BsonDocument("$unwind", "$employeeInfo");
            pipeline.Add(unwind);

            var project = new BsonDocument
            {
                { "$project", new BsonDocument
                    {
                        { "id", 1 },
                        { "date_reported", 1 },
                        { "subject", 1 },
                        { "incident_type", 1 },
                        { "reported_by", "$employeeInfo.first_name" },
                        { "priority", 1 },
                        { "deadline", 1 },
                        { "description", 1 },
                        { "status", 1 }
                    }
                }
            };
            pipeline.Add(project);

            List<Ticket> tickets = ticketCollection.Aggregate<Ticket>(pipeline).ToList();
            return tickets;
        }


        public List<Ticket> GetTicketsWithPastDeadlines(Employee employee)
        {
            var matchFilter = new BsonDocument
            {
                { "deadline", new BsonDocument { { "$lt", DateTime.UtcNow } } }
            };

            if (employee.UserType != UserType.ServiceDeskEmployee && employee.UserType != UserType.IcidentEmployee)
            {
                matchFilter.Add("reported_by", employee.Id);
            }

            var match = new BsonDocument
            {
                { "$match", matchFilter }
            };

            var lookup = new BsonDocument
            {
                {
                    "$lookup",
                    new BsonDocument
                    {
                        { "from", "employees" },
                        { "localField", "reported_by" },
                        { "foreignField", "_id" },
                        { "as", "employeeInfo" }
                    }
                }
            };

            var unwind = new BsonDocument("$unwind", "$employeeInfo");

            var project = new BsonDocument
            {
                {
                    "$project",
                    new BsonDocument
                    {
                        { "id", 1 },
                        { "date_reported", 1 },
                        { "subject", 1 },
                        { "incident_type", 1 },
                        { "reported_by", "$employeeInfo.first_name" },
                        { "priority", 1 },
                        { "deadline", 1 },
                        { "description", 1 },
                        { "status", 1 }
                    }
                }
            };

            var pipeline = new[] { match, lookup, unwind, project };

            // Execute the aggregation pipeline and return the results as a list of tickets
            List<Ticket> tickets = ticketCollection.Aggregate<Ticket>(pipeline).ToList();

            return tickets;
        }





        public void DeleteTicket(string ticketId)
        {
            ObjectId objectId;
            if (ObjectId.TryParse(ticketId, out objectId))
            {
                FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("_id", objectId);
                ticketCollection.DeleteOne(filter);
            }
            else
            {
                throw new Exception("there is no ticket with this id in the database");
            }
            
        }

        public void UpdateTicket(Ticket ticket) 
        {
            
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("_id", ticket.Id);
            UpdateDefinition<Ticket> update = Builders<Ticket>.Update

            .Set("subject", ticket.Subject)
            .Set("description", ticket.Description)
            .Set("deadline", ticket.Deadline)
            .Set("reported_by", ticket.ReportedBy)
            .Set("status", ticket.Status)
            .Set("priority", ticket.Priority)
            .Set("incident_type", ticket.IncidentType);

            ticketCollection.UpdateOne(filter, update);
        }

        public Ticket GetTicketByTicketId(string ticketId)
        {
            ObjectId objectId;
            if(ObjectId.TryParse(ticketId, out objectId))
            {
                FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("_id", objectId);
                return (Ticket)ticketCollection.Find(filter).First();
            }
            else
            {
                throw new Exception("there is no ticket with this id in the database");
            }
        }

        public List<Ticket> GetTicketsBasedOnKeywords(Employee loggedInEmployee, string searchInput)
        {
            string[] keywords = searchInput.Split(' ');
                List<string> keywordsToEmit = new List<string>();

                for (int i = 0; i < keywords.Length; i++)
                {
                    if (string.Equals(keywords[i], "and", StringComparison.OrdinalIgnoreCase))
                    {
                        keywordsToEmit.Add(keywords[i]);
                        keywords = keywords.Except(keywordsToEmit).ToArray();
                        return runAndQuery(loggedInEmployee, keywords);
                    }
                    else if (string.Equals(keywords[i], "or", StringComparison.OrdinalIgnoreCase))
                    {
                        keywordsToEmit.Add(keywords[i]);
                        keywords = keywords.Except(keywordsToEmit).ToArray();
                        return runOrQuery(loggedInEmployee, keywords);
                    }
                }
                return runOrQuery(loggedInEmployee,keywords);   
        }

        private List<FilterDefinition<Ticket>> buildFilters(Employee loggedInEmployee, string[] keywords)
        {
            var filters = new List<FilterDefinition<Ticket>>();
            foreach (string keyword in keywords)
            {
                var regexPattern = new BsonRegularExpression(new Regex(keyword, RegexOptions.IgnoreCase));
                var subjectFilter = Builders<Ticket>.Filter.Regex("subject", regexPattern);
                var descriptionFilter = Builders<Ticket>.Filter.Regex("description", regexPattern);
                var keywordFilter = Builders<Ticket>.Filter.Or(subjectFilter, descriptionFilter);

                filters.Add(keywordFilter);
            }


            return filters;
        }
        private List<Ticket> runAndQuery(Employee loggedInEmployee, string[] keywords) 
        {
            List<FilterDefinition<Ticket>> filters = buildFilters(loggedInEmployee, keywords);
            var andKeywordFilter = Builders<Ticket>.Filter.And(filters);            
            var employeeFilter = Builders<Ticket>.Filter.Eq("reported_by", loggedInEmployee.Id);
            var sortDefinition = Builders<Ticket>.Sort.Descending("date_reported");

            var combinedFilter = Builders<Ticket>.Filter.And(andKeywordFilter, employeeFilter);
            if(loggedInEmployee.UserType != UserType.ServiceDeskEmployee && loggedInEmployee.UserType != UserType.IcidentEmployee)
            {
                return ticketCollection.Find(combinedFilter).Sort(sortDefinition).ToList();
            }
            return ticketCollection.Find(andKeywordFilter).Sort(sortDefinition).ToList();
        }

        private List<Ticket> runOrQuery(Employee loggedInEmployee, string[] keywords) 
        {
            List<FilterDefinition<Ticket>> filters = buildFilters(loggedInEmployee, keywords);
            var orQueryFilter = Builders<Ticket>.Filter.Or(filters);
            var employeeFilter = Builders<Ticket>.Filter.Eq("reported_by", loggedInEmployee.Id);
            var sortDefinition = Builders<Ticket>.Sort.Descending("date_reported");

            var combinedFilter = Builders<Ticket>.Filter.And(orQueryFilter, employeeFilter);
            if (loggedInEmployee.UserType != UserType.ServiceDeskEmployee && loggedInEmployee.UserType != UserType.IcidentEmployee)
            {
                return ticketCollection.Find(combinedFilter).Sort(sortDefinition).ToList();
            }
            return ticketCollection.Find(orQueryFilter).Sort(sortDefinition).ToList();
        }

        public void CloseTicket(string ticketId)
        {
            ObjectId objectId;
            if (ObjectId.TryParse(ticketId, out objectId))
            {
                FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("_id", objectId);
                UpdateDefinition<Ticket> update = Builders<Ticket>.Update.Set("status", Status.Resolved.ToString());

                ticketCollection.UpdateOne(filter, update);
            }
            else
            {
                throw new Exception("There is no ticket with this ID in the database");
            }
        }
    }
}
