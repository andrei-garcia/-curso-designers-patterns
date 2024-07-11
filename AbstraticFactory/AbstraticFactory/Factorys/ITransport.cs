namespace AbstractFactory.Factorys

{
    using AbstractFactory.AircraftsNavs;
    using AbstractFactory.LandsVeicles;
    public interface ITransport
    {
        ILandsVeicles createTransportLand();
        ICrafts createTransportAir();
    }
}