namespace AbstractFactory.Factorys
{
    
    using AbstractFactory.AircraftsNavs;
    using AbstractFactory.LandsVeicles;
    
    class LineTransporte : ITransport
    {
        public ICrafts createTransportAir()
        {
            return new Drone();
        }

        public ILandsVeicles createTransportLand()
        {
            return new Car();
        }
    }
}