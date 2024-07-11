
namespace ConsoleApp1.Veicles
{
    using ConsoleApp1.Interfaces;
    class Bike : IVehicle
    {
        public void Cargo()
        {
            Console.WriteLine("pegando encomenda de bike");
        }

        public void Drive()
        {
            this.Cargo();
            Console.WriteLine("indo entregar encomenda de bike");
        }
    }
}