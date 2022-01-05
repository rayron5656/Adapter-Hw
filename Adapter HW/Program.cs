using System;

namespace Adapter_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDollar D = new Dollar();
            int x = 12;
            PaymentResult(D, x);

            IDollar D2 = new Adapter();
            x = 12;
            PaymentResult(D2,x);
            Console.ReadLine();

        }

        public static void PaymentResult(IDollar A,int Amount)
        {
            Console.WriteLine(A.paymnet(Amount));

        }
    }



}
