using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labs_EF.Entities
{
    [Table("Diagnoses")]
    public class Diagnoses : Entity
    {
        [Required(ErrorMessage = "The field is required!")]
        public string Comments { get; set; } = String.Empty;

        [Required(ErrorMessage = "The field is required!")]
        public string Diagnoses_title { get; set; } = String.Empty;

        [ForeignKey(nameof(Patients))]
        public Guid Patiens_ID { get; set; }

        public Patients Patients { get; set; } = null!;
    }
}
