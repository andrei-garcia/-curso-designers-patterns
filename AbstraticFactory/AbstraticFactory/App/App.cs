
namespace AbstractFactory.App

{
    using AbstractFactory.AircraftsNavs;
    using AbstractFactory.LandsVeicles;
    using AbstractFactory.Factorys;

    class Application(ITransport transport)
    {

        ILandsVeicles landsVeicles = transport.createTransportLand();
        ICrafts aircrafts = transport.createTransportAir();

        public void startRoute()
        {
            landsVeicles.startRoute();
            aircrafts.startRoute();
        }
    }
}