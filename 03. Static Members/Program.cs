using System;

namespace _03.Static_Members
{
    class clsA
    {
        public int X1;

        public static int X2;

        public int Method1()
        {
            return X1 + X2;
        }

        public static int Method2() 
        {
            return X2;
        }

        public int Method3()
        {
            return X2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsA objA1 = new clsA();
            clsA objA2 = new clsA();

            objA1.X1 = 7;
            objA2.X1 = 10;

            clsA.X2 = 100;

            Console.WriteLine(objA1.Method1());
            Console.WriteLine(objA2.Method1());

            Console.WriteLine(clsA.X2);
            Console.WriteLine(clsA.Method2());


            clsA.X2 = 200;
            Console.WriteLine(objA1.Method3());
        }
    }
}
