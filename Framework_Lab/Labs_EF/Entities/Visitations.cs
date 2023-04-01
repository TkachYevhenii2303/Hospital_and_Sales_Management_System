using System.ComponentModel.DataAnnotations;

namespace Labs_EF.Entities
{
    public class Visitations : Entity 
    {
        [Required]
        public string Comments { get; set; } = String.Empty;

        public DateTime Date { get; set; }

        public Patients Patients { get; set; }
    }
}
