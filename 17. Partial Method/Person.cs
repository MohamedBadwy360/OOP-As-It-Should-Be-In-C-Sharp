using System;


namespace _17.Partial_Method
{
    public partial class Person
    {
        public byte Age {get; set;}

        partial void PrintAge();

        public void Birthday()
        {
            Age++;
            PrintAge();
        }
    }
}
