namespace Bluider.Builders
{
    using Bluider.Components;
    using Bluider.Products;

    public interface IBluider
    { 
        void Reset();
        Vehicle GetVehicle();

        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmision transmission);
        void SetVehicleType(VheicleType vehicleType);
        
    }
}