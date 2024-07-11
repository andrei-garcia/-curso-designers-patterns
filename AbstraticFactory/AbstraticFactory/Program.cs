

using AbstractFactory.App;
using AbstractFactory.Factorys;
using System;

namespace AbstractFactory
{
    class Program
    {
       
        static void Main(string[] args)
        {

            ITransport transport = new Uber();
            Application app = new Application(transport);

            app.startRoute();

            ITransport transport2 = new Transport99();
            Application app2 = new Application(transport2);

            app2.startRoute();

            ITransport transport3 = new LineTransporte();
            Application app3 = new Application(transport3);

            app3.startRoute();

            Console.ReadLine();

        }
    }
}
