using Bluider.Builders;
using Bluider.Components;

namespace Bluider.Directors
{
    class VeicleDirector
    {

        IBluider builder;

        public VeicleDirector(IBluider builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {

            builder.SetVehicleType(VheicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmision.AUTOMATIC);

        }

        public void ConstructTruck()
        {

            builder.SetVehicleType(VheicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmision.MANUAL);

        }

    }
}
