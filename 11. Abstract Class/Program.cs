using System;

namespace _11.Abstract_Class
{
    public abstract class Person
    {
        public string Name { get; set; }

        public abstract void Introduce();

        public void SayGoodBye()
        {
            Console.WriteLine("GoodBye");
        }
    }

    public class Employee : Person
    {
        public int Id { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"My name is {Name} and My Id is {Id}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cant't create amn object from abstract class 
            //Person person = new Person();

            Employee employee = new Employee();

            employee.Name = "Mohamed Badwy";
            employee.Id = 1;

            employee.SayGoodBye();
            employee.Introduce();
        }
    }
}
