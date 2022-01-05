namespace Adapter_HW
{
    class Adapter : IDollar
    {
        private Ieuro Ieuro = new euro();

        public double paymnet(int x)
        {
            return Ieuro.payment(x);
        }
    }



}
