


using ConsoleApp1.Interfaces;

class Car : IVehicle
{

    public  void Drive()
    {
        
        this.Cargo();
        Console.WriteLine("dirigindo carro");
    }

    public void Cargo()
    {
        Console.WriteLine("pegando passageiros");
    }
}