using System;


namespace _01.Class___Object
{
    class clsPerson
    {
        public string FirstName;
        public string LastName;

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person1 = new clsPerson();
            Console.WriteLine(person1.FullName());
            Console.WriteLine(person1.FullName());

            person1.FirstName = "Mohamed";
            person1.LastName = "Badwy";
            Console.WriteLine(person1.FullName());

        }
    }
}
