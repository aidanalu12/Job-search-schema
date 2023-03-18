namespace Job_search_schema.Entities
{
    public class Seekers
    {
        public int Id { get; set; }
        public string NameSeekers { get; set; }
        public string ContactSeekers { get; set; }
        public string Experience { get; set; }
        public string Position { get; set;}
        public string DesiredWork { get; set;}
        public string Education { get; set;}
        public string Skills { get; set;}
        public List <Jobpostings> Jobpostings { get; set; }
    }
}
