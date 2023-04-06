using System.ComponentModel.DataAnnotations;

namespace Students_System.Entities
{
    public class Students : Entity
    {
        [Required]
        public string Students_name { get; set; } = string.Empty;

        [Required]
        public string Students_email { get; set; } = string.Empty;

        public DateTime Students_birthday { get; set; }

        [Required]
        public string Students_mobile { get; set; } = string.Empty;

        public ICollection<Homeworks> Homeworks { get; set; } = null!;

        public ICollection<Students_Courses> Students_Courses { get; set; } = null!;
    }
}
