namespace AbstractFactory.AircraftsNavs
{
    public class Aviator : ICrafts
    {
        public void getCargo()
        {
            Console.WriteLine("Avião em funcionamento com carga");
        }

        public void checkWind()
        {
            Console.WriteLine("Vento aferido, tudo pronto para decolagem");
        }

        public void startRoute()
        {
            this.getCargo();
            this.checkWind();
            Console.WriteLine("Avião iniciando decolagem para rotas aéreas");
        }
    }
}