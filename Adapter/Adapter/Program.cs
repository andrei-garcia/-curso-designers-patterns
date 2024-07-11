namespace Adapter
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //IPaypal payment = new Paypal();
            PionnerAdapter payment = new PionnerAdapter(new Pionner());
           
            payment.PlayPaypal();
            payment.RecivePaypal();

        }
    }
}
