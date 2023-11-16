using System;

namespace _12.Interfaces
{
    internal class Program
    {
        public interface IPerson
        {
            string FirstName { get; set; }
            string LastName { get; set; }

            void Introuduce();

            void Print();
        }

        public abstract class Person : IPerson
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public abstract void Introuduce();

            public abstract void Print();

            public void GoodBye()
            {
                Console.WriteLine("GoodBye");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
