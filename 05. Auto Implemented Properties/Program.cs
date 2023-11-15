using System;

namespace _05.Auto_Implemented_Properties
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();

            Console.WriteLine(employee1.Id);
            Console.WriteLine(employee1.Name);

            employee1.Id = 1;
            employee1.Name = "Mohamed Badwy";

            Console.WriteLine(employee1.Id);
            Console.WriteLine(employee1.Name);
        }
    }
}
