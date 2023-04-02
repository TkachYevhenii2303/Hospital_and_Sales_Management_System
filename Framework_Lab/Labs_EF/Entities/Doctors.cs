using System.ComponentModel.DataAnnotations;

namespace Labs_EF.Entities
{
    public class Doctors : Entity
    {
        [Required]
        public string Doctors_name { get; set; } = String.Empty;

        [Required]
        public Specialty Specialty { get; set; }

        public ICollection<Visitations> Visitations { get; set; }
    }
}
