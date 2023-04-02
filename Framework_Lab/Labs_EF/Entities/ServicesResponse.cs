namespace Labs_EF.Entities
{
    public class ServicesResponse<TEntity> where TEntity : class
    {
        public TEntity? Entity { get; set; }

        public string Message { get; set; } = "All operations are ok!";

        public bool Success { get; set; } = true;
    }
}
