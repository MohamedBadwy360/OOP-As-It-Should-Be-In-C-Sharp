using System;


namespace _17.Partial_Method
{
    public partial class Person
    {
        partial void PrintAge()
        {
            Console.WriteLine($"My age is {Age}");
        }
    }
}
