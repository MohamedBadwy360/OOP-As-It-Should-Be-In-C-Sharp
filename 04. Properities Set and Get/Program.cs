using System;


namespace _04.Properities_Set_and_Get
{
    class clsEmployee
    {
        private int _ID;
        private string _Name = string.Empty;

        public int ID
        {
            set
            {
                _ID = value;
            }

            get
            {
                return _ID;
            }
        }

        public string Name
        {
            set
            {
                _Name = value;
            }

            get
            {
                return _Name;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee employee1 = new clsEmployee();

            Console.WriteLine(employee1.ID);
            Console.WriteLine(employee1.Name);

            employee1.ID = 1;
            employee1.Name = "Mohamed Badwy";

            Console.WriteLine(employee1.ID);
            Console.WriteLine(employee1.Name);
        }
    }
}
