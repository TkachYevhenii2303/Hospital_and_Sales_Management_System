using System.ComponentModel.DataAnnotations;

namespace Students_System.Entities
{
    public class Courses : Entity
    {
        [Required]
        public string Courses_title { get; set; } = string.Empty;

        [Required]
        public string Courses_description { get; set; } = string.Empty;

        public DateTime Courses_end_Date { get; set; }

        public DateTime Courses_start_Date { get; set; }

        [Required]
        public decimal Courses_total { get; set;} = 0;

        public ICollection<Homeworks> Homeworks { get; set; } = null!;

        public ICollection<Students_Courses> Students_Courses { get; set; } = null!;

        public ICollection<Resources> Resources { get; set; } = null!;
    }
}
