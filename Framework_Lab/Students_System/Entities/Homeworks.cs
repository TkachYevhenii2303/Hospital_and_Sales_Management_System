namespace Students_System.Entities
{
    public class Homeworks : Entity
    {
        public string Content { get; set; } = string.Empty;

        public string Content_type { get; set; } = string.Empty;

        public DateTime Submissions_time { get; set; }

        public Students Students { get; set; } = null!;

        public Guid Students_ID { get; set; }

        public Courses Courses { get; set; } = null!;   

        public Guid Courses_ID { get; set; }
    }
}
