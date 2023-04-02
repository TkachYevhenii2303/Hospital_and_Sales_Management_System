namespace Sales_Shops.Entities
{
    public class Products : Entity
    {
        public string Products_title { get; set; }

        public decimal Products_price { get; set;}

        public int Products_amount { get; set;}

        public ICollection<Sales> Sales { get; set; } = null!;
    }
}
