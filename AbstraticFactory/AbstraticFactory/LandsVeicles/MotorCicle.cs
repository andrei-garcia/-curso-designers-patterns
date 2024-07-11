namespace AbstractFactory.LandsVeicles
{
    class MotorCicle : ILandsVeicles
    {
        public void getCargo()
        {
            Console.WriteLine("Moto em funcionamento com carga");
        }

        public void startRoute()
        {
            this.getCargo();
            Console.WriteLine("Moto iniciando trajeto terrestre");
        }
    }
}