namespace Adapter
{
    public class Paypal : IPaypal
    {
        public void PlayPaypal()
        {
            Console.WriteLine("pay is PlayPaypal");
        }

        public void RecivePaypal()
        {
            Console.WriteLine("recive is RecivePaypal");
        }
    }
}