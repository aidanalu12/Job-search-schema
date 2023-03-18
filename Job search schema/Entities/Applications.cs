namespace Job_search_schema.Entities
{
    public class Applications
    {
        public int Id { get; set; }
        public string IdJobpostings { get; set; }
        public DateTime DateApplication { get; set;}
        public string ApplicationMethod { get; set;}
        public string ApplicationStatus { get; set;}
        public List<Jobpostings> Jobpostings { get; set; }
    }
}
