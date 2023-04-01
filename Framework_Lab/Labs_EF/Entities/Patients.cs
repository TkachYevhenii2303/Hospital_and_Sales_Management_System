using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Labs_EF.Entities
{
    public class Patients : Entity
    {
        [Required][Unicode]
        public string Address { get; set; } = String.Empty;

        [Required][Unicode]
        public string Patients_first_name { get; set; } = String.Empty;

        [Required][Unicode]
        public string Patients_last_name { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public bool Has_Insuranse { get; set; } = false;

        public ICollection<Diagnoses> Diagnoses { get; set; }

        public ICollection<Visitations> Visitations { get; set; }

        public ICollection<Medicaments> Medicaments { get; set; }
    }
}
