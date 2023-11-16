using System;


namespace _14.Sealed_Class
{
    sealed class clsA
    {

    }

    // Cant't inherit from class clsA
    class clsB : clsA
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
