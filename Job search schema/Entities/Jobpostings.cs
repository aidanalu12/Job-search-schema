namespace Job_search_schema.Entities
{
    public class Jobpostings
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public DateTime PublicationDate { get; }
        public string PublicationUrl { get; set; }
        public string KeySkills { get; set; }
        public List<Interviews> interviews { get; set; }  
        public List<Applications> Applications { get; set; } 
        public List<Seekers> Seekers { get; set; }

    }
}
