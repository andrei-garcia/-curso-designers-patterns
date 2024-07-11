namespace AbstractFactory.Factorys
{
    using AbstractFactory.AircraftsNavs;
    using AbstractFactory.LandsVeicles;
    
    class Uber : ITransport
    {
        public ICrafts createTransportAir()
        {
            return new Helicoptero();
        }

        public ILandsVeicles createTransportLand()
        {
            return new MotorCicle();
        }
    }
}