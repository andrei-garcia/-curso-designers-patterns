using Bluider.Components;

namespace Bluider.Products
{
    public class Vehicle
    {

        private VheicleType vehicleType;
        private int seats;
        private Engine engine;
        private Transmision transmission;

        public VheicleType VehicleType
        {
            get => vehicleType;
            set => vehicleType = value;
        }

        public int Seats
        {
            get => seats;
            set => seats = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Transmision Transmission
        {
            get => transmission;
            set => transmission = value;
        }


    }
}
