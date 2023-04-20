namespace Pizza_System_BLL.Repositories.Interfaces
{
    public interface IUnit_of_Work : IDisposable
    {
        public int Complete();

        public IPizzaRepository _Pizza_Repository { get; set; }

        public ISauceRepository _Sause_Repository { get; set; }
        
        public IToppingsRepository _Toppings_Repository { get; set; }
    }
}
