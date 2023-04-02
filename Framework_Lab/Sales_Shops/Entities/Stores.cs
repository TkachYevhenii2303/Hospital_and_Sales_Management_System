namespace Sales_Shops.Entities
{
    public class Stores : Entity
    {
        public string Stores_title { get; set; }

        public ICollection<Sales> Sales { get; set; } = null!;
    }
}
