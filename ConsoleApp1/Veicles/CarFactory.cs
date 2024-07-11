
namespace ConsoleApp1.Veicles
{
    using ConsoleApp1.Interfaces;
    class CarFactory : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}