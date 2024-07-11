
namespace ConsoleApp1.Veicles
{
    using ConsoleApp1.Interfaces;
    class MotorcicleFactory : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcicle();
        }
    }
}