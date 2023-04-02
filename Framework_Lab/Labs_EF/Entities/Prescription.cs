namespace Labs_EF.Entities
{
    public class Prescription : Entity
    {
        public Guid Patients_ID { get; set; }

        public Patients Patients { get; set; }

        public Guid Medicaments_ID { get; set; }    

        public Medicaments Medicaments { get; set; }
    }
}
