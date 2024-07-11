namespace Bluider.Components
{
    public class Engine
    {
        private int Power;

        public Engine(int v)
        {
            this.Power = v;
        }

        public int GetPower()
        {
            return Power;
        }

        public void SetPower(int power)
        {
            this.Power = power;
        }
    }
}