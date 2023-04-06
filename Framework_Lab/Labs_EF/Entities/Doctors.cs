using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labs_EF.Entities
{
    [Table("Doctors")]
    public class Doctors : Entity
    {
        [Required(ErrorMessage = "The field is required!")]
        [StringLength(100, ErrorMessage = "The legnt of this field must be less than 100 characters!")]
        public string Doctors_name { get; set; } = String.Empty;

        [Required(ErrorMessage = "The field is required!")]
        public Specialty Specialty { get; set; }

        public ICollection<Visitations> Visitations { get; set; } = null!;
    }
}
