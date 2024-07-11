namespace Adapter
{
    public class Pionner : IPionner
    {
        public void Play()
        {
            Console.WriteLine("Pionner is playing");
        }

        public void Recive()
        {
            Console.WriteLine("Pionner is reciving");
        }
    }
}