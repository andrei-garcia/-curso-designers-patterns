namespace AbstractFactory.AircraftsNavs
{
    public class Drone : ICrafts
    {
        public void getCargo()
        {
            Console.WriteLine("Drone em funcionamento com camera ligada");
        }

        public void checkWind()
        {
            Console.WriteLine("Bateria verificada, tudo pronto  para decolagem");
        }

        public void startRoute()
        {
            this.getCargo();
            this.checkWind();
            Console.WriteLine("Drone iniciando decolagem para rotas aéreas");
        }
    }
}