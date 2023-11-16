using System;


namespace _07.Parameterized_Constructor
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }

        public Employee(int Id, string Name, byte Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        public Employee()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Mohamed Badwy", 23);

            Console.WriteLine($"ID = {employee.Id}");
            Console.WriteLine($"Name = {employee.Name}");
            Console.WriteLine($"Age = {employee.Age}");
        }
    }
}
