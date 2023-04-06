using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labs_EF.Entities
{
    [Table("Patients")]
    public class Patients : Entity
    {
        [Required(ErrorMessage = "The field is required!")]
        [StringLength(100, ErrorMessage = "The legnt of this field must be less than 100 characters!")]
        [Unicode]
        public string Address { get; set; } = String.Empty;

        [Required(ErrorMessage = "The field is required!")]
        [StringLength(100, ErrorMessage = "The legnt of this field must be less than 100 characters!")]
        [Unicode]
        public string Patients_Last { get; set; } = String.Empty;

        [Required(ErrorMessage = "The field is required!")]
        [StringLength(100, ErrorMessage = "The legnt of this field must be less than 100 characters!")]
        [Unicode]
        public string Patients_First { get; set; } = String.Empty;

        [EmailAddress]
        public string Email { get; set; } = String.Empty;

        public bool Has_Insuranse { get; set; } = false;

        public ICollection<Diagnoses> Diagnoses { get; set; } = null!;

        public ICollection<Visitations> Visitations { get; set; } = null!;

        public ICollection<Prescription> Prescriptions { get; set; } = null!;
    }
}
