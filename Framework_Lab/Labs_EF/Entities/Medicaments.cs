using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labs_EF.Entities
{
    [Table("Medicaments")]
    public class Medicaments : Entity
    {
        [Required(ErrorMessage = "The field is required!")]
        [StringLength(100, ErrorMessage = "The legnt of this field must be less than 100 characters!")]
        public string Medicaments_title { get; set; } = String.Empty;

        public ICollection<Prescription> Prescriptions { get; set; } = null!;
    }
}
