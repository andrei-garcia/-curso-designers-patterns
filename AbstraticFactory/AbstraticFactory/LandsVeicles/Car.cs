namespace AbstractFactory.LandsVeicles
{
    class Car : ILandsVeicles
    {
        public void getCargo()
        {
            Console.WriteLine("Carro em funcionamento com carga");
        }

        public void startRoute()
        {
            this.getCargo();
            Console.WriteLine("Carro iniciando trajeto terrestre");
        }
    }
}