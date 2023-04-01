namespace Labs_EF.Entities
{
    public class Medicaments : Entity
    {
        public string Medicaments_title { get; set; } = String.Empty;

        public ICollection<Patients> Patients { get; set; }
    }
}
