namespace Adapter
{
    public class PionnerAdapter : IPaypal
    {
        private IPionner pionner;

        public PionnerAdapter(IPionner Pionner)
        {
            pionner = Pionner;
        }

        public void PlayPaypal()
        {
            pionner.Play();
        }

        public void RecivePaypal()
        {
            pionner.Recive();
        }
    }
}