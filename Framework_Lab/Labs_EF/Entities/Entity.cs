using System.ComponentModel.DataAnnotations;

namespace Labs_EF.Entities
{
    public abstract class Entity
    {
        public Guid ID { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }
    }
}
