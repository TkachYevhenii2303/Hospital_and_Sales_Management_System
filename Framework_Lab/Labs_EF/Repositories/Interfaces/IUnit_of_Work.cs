namespace Labs_EF.Repositories.Interfaces
{
    public interface IUnit_of_Work : IDisposable
    {
        public IDoctrosRepository Doctros_Repository { get; }

        public IPatientsRepository Patients_Repository { get; }

        public IVisitationsRepository Visitations_Repository { get; }

        public int Complete();
    }
}
