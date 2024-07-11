

using ConsoleApp1.Interfaces;
using ConsoleApp1.Veicles;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! sou o main do Program.cs");

        Transport transport = new CarFactory();
        transport.StartTransport();

        Console.WriteLine("====================================");

        Transport transport2 = new MotorcicleFactory();
        transport2.StartTransport();

        Console.WriteLine("====================================");

        Transport transport3 = new BikeFactory();
        transport3.StartTransport();
    }
}
