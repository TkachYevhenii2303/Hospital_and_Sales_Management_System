using System.ComponentModel.DataAnnotations;

namespace Labs_EF.Entities
{
    public class Doctors : Entity
    {
        [Required]
        public string Doctors_name { get; set; } = String.Empty;

        [Required]
        public string Specialty { get; set; } = String.Empty;

        public ICollection<Visitations> Visitations { get; set; }
    }
}
