using System;


namespace _06.Parameterless_Constructor
{
    class Person
    {
        public int Id {set; get;}
        public string Name { set; get;}
        public byte Age { set; get;}
        
        // Parameterless Constructor
        public Person()
        {
            Id = -1;
            Name = "Empyt";
            Age = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            Console.WriteLine(person1.Id);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
        }
    }
}
