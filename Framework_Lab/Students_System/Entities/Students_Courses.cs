namespace Students_System.Entities
{
    public class Students_Courses : Entity
    {
        public Students Students { get; set; } = null!;

        public Guid Students_ID { get; set; }

        public Courses Courses { get; set; } = null!;

        public Guid Courses_ID { get; set; }
    }
}
