namespace Bluider.Builders
{
    using Bluider.Components;
    using Bluider.Products;

    public class CarBluider : IBluider
    {
        private Vehicle vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            Vehicle result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetVehicleType(VheicleType vheicleType)
        {
            vehicle.VehicleType = vheicleType;
        }

        public void SetSeats(int seats)
        {
            vehicle.Seats = seats;
        }

        public void SetEngine(Engine engine)
        {
            vehicle.Engine = engine;
        }

        public void SetTransmission(Transmision transmission)
        {
            vehicle.Transmission = transmission;
        }

    }
}
