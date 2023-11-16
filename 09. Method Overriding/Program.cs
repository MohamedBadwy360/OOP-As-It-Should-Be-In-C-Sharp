using System;


namespace _09.Method_Overriding
{
    internal class Program
    {
        class clsA
        {
            public virtual void Print()
            {
                Console.WriteLine("From Class A");
            }
        }

        class clsB : clsA
        {
            public override void Print()
            {
                //base.Print();
                Console.WriteLine("From class B");
            }
        }
        static void Main(string[] args)
        {
            clsB objB = new clsB();
            objB.Print();
        }
    }
}
