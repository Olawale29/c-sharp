using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Types
            //int, string, long, float, double, bool, char

            //The int data type can store whole numbers from -2147483648 to 2147483647
            int myNum = 100000;
            Console.WriteLine(myNum);

            long myNumber = 150000000000000000L;
            Console.WriteLine(myNumber);

            //You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.
            //Note that you should end the value with an "F" for floats and "D" for doubles:
            float floatedNumber = 7.89F;
            Console.WriteLine(floatedNumber);

            double doubleNumber = 19.99D;
            Console.WriteLine(doubleNumber);

            //The precision of a floating point value indicates
            //how many digits the value can have after the decimal point. The precision of float is only six
            //or seven decimal digits, while double variables have a precision of about 15 digits. Therefore
            //it is safer to use double for most calculations.

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            //Boolean
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            //Char
            char myGrade = 'B';
            Console.WriteLine(myGrade);

            //string
            string my_name = "Emmanuel"; //string values must be sorrounded with double quotes 
            Console.WriteLine(my_name);



            //Type Casting
            //Implicit casting - converting a smaller type to a larger type size automatically
            //Explicit casting - conconverting a smaller type to a larger type size manually


            //Implicit
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);


            //Explicit
            double myDoubles = 9.83;
            int myInteger = (int)myDoubles;
            Console.WriteLine(myDoubles);
            Console.WriteLine(myInteger);

            //Type Conversion methods
            int myInts = 10;
            double myDoubless = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInts));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubless));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            //User Input
            Console.WriteLine("What is your age");
            int age  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            //operations
            int x = 100 + 50;
            int sum1 = 100 + 50;
            int sum2 = 100 + sum1;
            int sum3 = sum1 + sum2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.WriteLine(x);

            //Arithmetic operaation
            //+ - Addition
            //- Subtraction
            //* - Multiplication
            // / - Division
            // % - Modules - returns the division remainder
            // ++ increment
            //-- decrement

            int z = 10;
            z += 5;
            Console.WriteLine(z);

            //assignment operatiord

            //+=
            //-=
            //*=
            ///=
            //%=
            //&=
            //|=
            //^=
            //>>=
            //<<=

            //comparison operators
            int d = 5;
            int c = 3;
            Console.WriteLine(d > c);




        }
    }



}
