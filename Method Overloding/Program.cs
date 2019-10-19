using System;

namespace Method_Overloding
{
    class Program
    {
        static void Main(string[] args)
        {
            double Product = 0;
            Print(10, 20);

            Print(10, 20, 30);

            Print(10.25, 20.5);

            Print(100, 50, out Product);
        }
        public static void Print(int Fn,int sn)
        {
            Console.WriteLine("Sum ={0}", Fn + sn);
        }

        //Functions can be overloaded based on number of parameeter.
        public static void Print(int Fn, int sn,int tn)
        {
            Console.WriteLine("Sum ={0}", Fn + sn + tn);

        }

        //Functions can be overloaded based on type of parameeter.
        public static void Print(double Fn, double sn)
        {
            Console.WriteLine("Sum ={0}", Fn + sn);

        }

        //Functions can be overloaded based on kind of parameeter.
        public static void Print(int Fn, int sn, out double Product)
        {
            Product = Fn * sn;
            Console.WriteLine("Sum ={0} - Prodyct ={1}", Fn + sn,Product);

        }
    }
}
