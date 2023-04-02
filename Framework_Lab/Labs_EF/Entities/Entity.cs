using System.ComponentModel.DataAnnotations;

namespace Labs_EF.Entities
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }
    }
}
