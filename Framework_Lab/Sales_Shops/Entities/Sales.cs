namespace Sales_Shops.Entities
{
    public class Sales : Entity
    {
        public Guid Customer_ID { get; set; }

        public Customers Customers { get; set; }    

        public Guid Stores_ID { get; set; }

        public Stores Stores { get; set; }  

        public Guid Products_ID { get; set; }

        public Products Products { get; set; }
    }
}
