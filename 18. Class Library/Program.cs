using System;
using MyFirstClassLibrary;

namespace _18.Class_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            Console.WriteLine(myMath.Sum(10, 20));
            myMath.Hello();

            
        }
    }
}
