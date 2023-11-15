using System;

namespace _02.Access_Modifiers
{
    class clsA
    {
        public int X1 = 10;
        private int X2 = 20;
        protected int X3 = 30;

        public int Func1()
        {
            return 100;
        }

        private int Func2()
        {
            return 200;
        }

        protected int Func3()
        {
            return 300;
        }

        public int Func4()
        {
            return Func2();
        }
    }

    class clsB : clsA
    {
        public int Func()
        {
            return X1 + X3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsA A = new clsA();

            Console.WriteLine(A.X1);
            Console.WriteLine(A.Func1());
            Console.WriteLine(A.Func4());

            clsB B = new clsB();
            Console.WriteLine(B.Func());
            Console.WriteLine(B.X1);
            Console.WriteLine(B.Func1());
            Console.WriteLine(B.Func4());
        }
    }
}
