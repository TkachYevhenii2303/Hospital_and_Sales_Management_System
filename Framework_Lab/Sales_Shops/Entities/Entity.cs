using System.ComponentModel.DataAnnotations;

namespace Sales_Shops.Entities
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }
    }
}
