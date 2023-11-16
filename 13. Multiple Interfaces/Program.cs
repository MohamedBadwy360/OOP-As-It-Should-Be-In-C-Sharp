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

        public interface ICommunicate
        {
            void SendEmail();

            void SendFax();

            void SendSMS();
        }

        public abstract class Person : IPerson, ICommunicate
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public abstract void Introuduce();

            public abstract void Print();

            public void GoodBye()
            {
                Console.WriteLine("GoodBye");
            }

            public abstract void SendEmail();

            public abstract void SendFax();

            public abstract void SendSMS();
        }
        static void Main(string[] args)
        {
        }
    }
}

