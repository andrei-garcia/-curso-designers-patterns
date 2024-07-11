namespace ConsoleApp1.Veicles
{
    using ConsoleApp1.Interfaces;
    class BikeFactory : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}