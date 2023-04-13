using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labs_EF.Entities
{
    [Table("Visitations")]
    public class Visitations : Entity 
    {
        [Required(ErrorMessage = "The field is required!")]
        [StringLength(100, ErrorMessage = "The legnt of this field must be less than 100 characters!")]
        public string Comments { get; set; } = String.Empty;

        public DateTime Date { get; set; }

        [ForeignKey(nameof(Patients))]
        public Guid Patients_ID { get; set; }

        [ForeignKey(nameof(Doctors))]
        public Guid Doctors_ID { get; set; }

        public Patients Patients { get; set; } = null!;

        public Doctors Doctors { get; set; } = null!;
    }
}
