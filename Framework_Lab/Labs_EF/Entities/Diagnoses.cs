using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labs_EF.Entities
{
    public class Diagnoses : Entity
    {
        [Required]
        public string Comments { get; set; } = String.Empty;

        [Required]
        public string Diagnoses_title { get; set; } = String.Empty;

        public Guid Patiens_ID { get; set; }

        public Patients Patients { get; set; } = null!;
    }
}
