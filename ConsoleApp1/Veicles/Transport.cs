
namespace ConsoleApp1.Interfaces;
abstract class Transport
{

    public void StartTransport()
    {

        IVehicle vehicle = CreateTransport();
        vehicle.Drive();

    }

    protected abstract IVehicle CreateTransport();

}

