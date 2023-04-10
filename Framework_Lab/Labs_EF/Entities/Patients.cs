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
        public string Patients_first_name { get; set; } = String.Empty;

        [Required(ErrorMessage = "The field is required!")]
        [StringLength(100, ErrorMessage = "The legnt of this field must be less than 100 characters!")]
        [Unicode]
        public string Patients_last_name { get; set; } = String.Empty;

        [EmailAddress]
        public string Email { get; set; } = String.Empty;

        public bool Has_Insuranse { get; set; } = false;

        public virtual ICollection<Diagnoses> Diagnoses { get; set; } = null!;

        public virtual ICollection<Visitations> Visitations { get; set; } = null!;

        public virtual ICollection<Prescription> Prescriptions { get; set; } = null!;
    }
}
