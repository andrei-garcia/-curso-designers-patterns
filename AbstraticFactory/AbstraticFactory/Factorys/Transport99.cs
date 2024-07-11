namespace AbstractFactory.Factorys
{
    
    using AbstractFactory.AircraftsNavs;
    using AbstractFactory.LandsVeicles;
    
    class Transport99 : ITransport
    {
        public ICrafts createTransportAir()
        {
            return new Aviator();
        }

        public ILandsVeicles createTransportLand()
        {
            return new Car();
        }
    }
}