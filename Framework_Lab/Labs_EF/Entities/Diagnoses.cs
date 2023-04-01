using System.ComponentModel.DataAnnotations;

namespace Labs_EF.Entities
{
    public class Diagnoses : Entity
    {
        [Required]
        public string Comments { get; set; } = String.Empty;

        [Required]
        public string Diagnoses_title { get; set; } = String.Empty;

        public Patients Patients { get; set; }
    }
}
