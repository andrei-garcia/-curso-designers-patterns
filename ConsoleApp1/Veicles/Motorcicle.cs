


using ConsoleApp1.Interfaces;

class Motorcicle : IVehicle
{

    public  void Drive()
    {
        
        this.Cargo();
        Console.WriteLine("dirigindo carro moto");
    }

    public void Cargo()
    {
        Console.WriteLine("pegando passageiros de moto");
    }
}