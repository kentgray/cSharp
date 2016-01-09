using Csharp_Drills;
using System;

public class Program
{
    public static void Main()
    {
        BaseClass B = new DerivedClass();
        B.Print();
        //show the add f(x)
        Overloading.Add(2, 3);
        //show the overloaded add f(x)
        Overloading.Add(2.3F, 3.4F);
        //create a customer
        Customer C1 = new Customer("Tony", "Wittinger");
        C1.PrintFullName();
        //show the use of 'this'
        Circle Cir = new Circle(5);
        float Area = Cir.CalculateArea();
        Console.WriteLine("Area = {0}\n", Area);
        //Show the struct feature
        Student S1 = new Student(234, "Tony");
        S1.PrintDetails();
        
    }
}
public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("\nThis is the Base Class Print Method\n");
    }
}

public class DerivedClass : BaseClass //Deriving a class from the Base Class
{
    public override void Print() //replace override w/ new to hide the method
    {
        Console.WriteLine("\nThis is the Derived Class Print Method Showing the Override feature\n");
    }
}


public class Overloading
{
    public static void Add(int FN, int SN) //First method that adds
    {
        Console.WriteLine("The Sum of the First Add function is {0}\n", FN + SN);
    }
    public static void Add(float FN, float SN) //Overloading the first method of Add.
    {
        Console.WriteLine("The Sum of the Overloaded Add function is {0}\n", FN + SN);
    }
   
}
