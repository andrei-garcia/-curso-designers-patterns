namespace AbstractFactory.AircraftsNavs
{
    public class Helicoptero : ICrafts
    {
        public void getCargo()
        {
            Console.WriteLine("Helicoptero em funcionamento com carga");
        }

        public void checkWind()
        {
            Console.WriteLine("Vento aferido, tudo pronto para decolagem");
        }

        public void startRoute()
        {
            this.getCargo();
            this.checkWind();
            Console.WriteLine("Helicoptero iniciando decolagem para rotas aéreas");
        }
    }
}