namespace Students_System.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        public DateTime Created_at { get; private set; }    

        public DateTime Updated_at { get; private set; }
    }
}
