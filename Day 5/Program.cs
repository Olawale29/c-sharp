using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
            MyMethods("Oyegunle");
            DefaultParameter();
            Console.WriteLine(Calculator(5, 3));
            Youngest(child1: "lanre", child2: "toheeb", child3: "wale");
            Console.WriteLine(calculateSmallestAge(10, 20, 40));
            int myNum1 = PlusMethodInt(5, 4);
            double doubleNum = PlusMethodDouble(4.3, 5.8);
            Console.WriteLine($"Int value => {myNum1}");
            Console.WriteLine($"Double value => {doubleNum}");
            int plusMethod1 = PlusMethod(5, 4);
            double plusMethod2 = PlusMethod(4.3, 6.2);
            Console.WriteLine($"Int value => {plusMethod1}");
            Console.WriteLine($"Double value => {plusMethod2}");
            

        }

        static void MyMethod()
        {
            Console.WriteLine("Hello world");
        }

        static void MyMethods(string fname)
        {
            Console.WriteLine($"{fname} Emmanuel");
        }

        //Default parameter

        static void DefaultParameter(string country = "nigeria")
        {
            Console.WriteLine(country);
        }

        static int Calculator(int x, int y)
        {
            return x + y;
        }

        static void Youngest(string child1,  string child2, string child3)
        {
            Console.WriteLine($"The youngest child is {child3}");
        }

        static int calculateSmallestAge(int age1, int age2, int age3)
        {
           int smallest = Math.Min(age1, Math.Min(age2, age3));
            return smallest;
            
        }

        //c# overloading
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }
        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        //Instead of defining two methods that should do the same thing, it is better to overload one
        //In the example below, we overload the PlusMethod method to work for both int and double:

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }











    }
}