namespace Students_System.Entities
{
    public class Resources : Entity
    {
        public Guid Courses_ID { get; set; }

        public Courses Courses { get; set; } = null!;

        public string Resources_title { get; set; } = string.Empty;

        public string Resources_type { get; set;} = string.Empty;

        public string Resources_url { get; set; } = string.Empty;
    }
}
