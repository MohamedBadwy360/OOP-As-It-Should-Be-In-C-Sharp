using System;

class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Base Class Print Function Implelmentation");
    }

    public virtual void OtherPrint()
    {
        Console.WriteLine("Base Class Other Print Function Implelmentation");
    }
}

class DerivedClass : BaseClass
{
    public override void Print()
    {
        Console.WriteLine("Derived Class Print Function Implelmentation");
    }

    // Hiding or Shadowing
    public new void OtherPrint()
    {
        Console.WriteLine("Derived Class Other Print Function Implelmentation");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Base Class");
        BaseClass objBase = new BaseClass();
        objBase.Print();
        objBase.OtherPrint();


        Console.WriteLine("\nDerived Class");
        DerivedClass objDerived = new DerivedClass();
        objDerived.Print();
        objDerived.OtherPrint();

        Console.WriteLine("\nAfter Casting");
        BaseClass objBase2 = new DerivedClass();
        objBase2.Print();
        objBase2.OtherPrint();
    }
}

