﻿namespace Job_search_schema.Entities
{
    public class Interviews
    {
        public int Id { get; set; }
        public int IdJobpostings { get; set; }
        public DateTime DateInterview { get; set; }
        public DateTime TimeInterview { get; set; }
        public string ContactPerson { get; set; }
        public string Status { get; set; }
        public int JobpostingsId {get; set;}
        public Jobpostings Jobpostings  { get; set; }
    }
}
