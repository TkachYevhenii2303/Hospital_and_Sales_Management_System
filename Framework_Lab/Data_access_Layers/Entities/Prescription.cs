using System.ComponentModel.DataAnnotations.Schema;

namespace Labs_EF.Entities
{
    [Table("Prescription_Medicaments")]
    public class Prescription : Entity
    {
        [ForeignKey(nameof(Patients))]
        public Guid Patients_ID { get; set; }

        public Patients Patients { get; set; } = null!;

        [ForeignKey(nameof(Medicaments))]
        public Guid Medicaments_ID { get; set; }    

        public virtual Medicaments Medicaments { get; set; } = null!;
    }
}
