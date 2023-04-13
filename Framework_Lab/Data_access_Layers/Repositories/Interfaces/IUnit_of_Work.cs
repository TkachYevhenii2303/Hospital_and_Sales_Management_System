namespace Labs_EF.Repositories.Interfaces
{
    public interface IUnit_of_Work : IDisposable
    {
        public IDoctrosRepository Doctros_Repository { get; }

        public int Complete();
    }
}
