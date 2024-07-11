
namespace Bluider
{
    using Bluider.Builders;
    using Bluider.Directors;
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new CarBluider();
            var director = new VeicleDirector(builder);

            director.ConstructSedanCar();
            var sedan = builder.GetVehicle();

            Console.WriteLine("sedan com engine: " + sedan.Engine.GetPower() + " and seats: " + sedan.Seats);

            director.ConstructTruck();
            var truck = builder.GetVehicle();

            Console.WriteLine("truck com engine: " + truck.Engine.GetPower() + " and seats: " + truck.Seats);
        }
    }
}