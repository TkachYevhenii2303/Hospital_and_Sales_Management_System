using System.ComponentModel.DataAnnotations;

namespace Labs_EF.Entities
{
    public class Visitations : Entity 
    {
        [Required]
        public string Comments { get; set; } = String.Empty;

        public DateTime Date { get; set; }

        public Guid Patients_ID { get; set; }

        public Guid Doctors_ID { get; set; }

        public Patients Patients { get; set; } = null!;

        public Doctors Doctors { get; set; } = null!;
    }
}
