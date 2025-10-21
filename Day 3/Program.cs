using System;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("What is your name ");
            //string name = Console.ReadLine();
            //Console.WriteLine("What is your age ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Hello {name}, you are {age} years old!");

            //Console.WriteLine("Please input first number ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter second number ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Addition of the two numbers is {number1 + number2}");
            //Console.WriteLine($"Subtraction of the two numbers is {number1 - number2}");
            //Console.WriteLine($"Multiplication of the two numbers is {number1 * number2}");
            //Console.WriteLine($"Division of the two numbers is {number1 / number2}");

            //Console.WriteLine("What is your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //int age_in_months = age * 12;
            //int age_in_weeks = age * 52;
            //int age_in_days = age * 365;
            //Console.WriteLine($"You are {age_in_months} months old");
            //Console.WriteLine($"You are {age_in_weeks} weeks old");
            //Console.WriteLine($"You are {age_in_days} days old");

            //Console.WriteLine("What is your temperature in celsius");
            //double celsius = Convert.ToDouble(Console.ReadLine());
            //double F = (celsius * 9 / 5) + 32;
            //Console.WriteLine($"Your temperature is {F} degree Fahrenheit");




            //Console.WriteLine("Input first number");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input second number");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //if(number1 > number2)
            //{
            //    Console.WriteLine($"The first number {number1} is greater than the second number {number2}");
            //}else if(number1 < number2)
            //{
            //    Console.WriteLine($"The second number {number2} is greater than the first number {number1}");
            //}
            //else
            //{
            //    Console.WriteLine("Both numbers are equals to each other");
            //}


            //Console.WriteLine("What is the width of the rectangle");
            //double width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("What is the height of the rectangle");
            //double height = Convert.ToDouble(Console.ReadLine());
            //double Area = width * height;
            //Console.WriteLine($"The Area of the rectangle is {Area}");

            int score = 0;
            Console.WriteLine("What is 10 + 5?");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is 5 * 4?");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is 60 - 20?");
            int answer3 = Convert.ToInt32(Console.ReadLine());


            if(answer1 == 15 && answer2 == 20 && answer3 == 40 )
            {
                score += 30;
      
            }else if(answer1 != 15 && answer2 == 20 && answer3 == 40)
            { 
                score += 20;
              
            }else if (answer1 != 15 && answer2 != 20 && answer3 == 40)
            {
                score += 10;
               
            }
            else
            {
                score = 0;
              
            }

            Console.WriteLine($"Your result is {score}/30");



     

            

            
            






            ////Data Types
            ////int, string, long, float, double, bool, char

            ////The int data type can store whole numbers from -2147483648 to 2147483647
            //int myNum = 100000;
            //Console.WriteLine(myNum);

            //long myNumber = 150000000000000000L;
            //Console.WriteLine(myNumber);

            ////You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.
            ////Note that you should end the value with an "F" for floats and "D" for doubles:
            //float floatedNumber = 7.89F;
            //Console.WriteLine(floatedNumber);

            //double doubleNumber = 19.99D;
            //Console.WriteLine(doubleNumber);

            ////The precision of a floating point value indicates
            ////how many digits the value can have after the decimal point. The precision of float is only six
            ////or seven decimal digits, while double variables have a precision of about 15 digits. Therefore
            ////it is safer to use double for most calculations.

            //float f1 = 35e3F;
            //double d1 = 12E4D;
            //Console.WriteLine(f1);
            //Console.WriteLine(d1);

            ////Boolean
            //bool isCSharpFun = true;
            //bool isFishTasty = false;
            //Console.WriteLine(isCSharpFun);   // Outputs True
            //Console.WriteLine(isFishTasty);   // Outputs False

            ////Char
            //char myGrade = 'B';
            //Console.WriteLine(myGrade);

            ////string
            //string my_name = "Emmanuel"; //string values must be sorrounded with double quotes 
            //Console.WriteLine(my_name);



            ////Type Casting
            ////Implicit casting - converting a smaller type to a larger type size automatically
            ////Explicit casting - conconverting a smaller type to a larger type size manually


            ////Implicit
            //int myInt = 9;
            //double myDouble = myInt;
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myInt);


            ////Explicit
            //double myDoubles = 9.83;
            //int myInteger = (int)myDoubles;
            //Console.WriteLine(myDoubles);
            //Console.WriteLine(myInteger);

            ////Type Conversion methods
            //int myInts = 10;
            //double myDoubless = 5.25;
            //bool myBool = true;

            //Console.WriteLine(Convert.ToString(myInts));    // convert int to string
            //Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            //Console.WriteLine(Convert.ToInt32(myDoubless));  // convert double to int
            //Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            ////User Input
            //Console.WriteLine("What is your age");
            //int age  = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is " + age);

            ////operations
            //int x = 100 + 50;
            //int sum1 = 100 + 50;
            //int sum2 = 100 + sum1;
            //int sum3 = sum1 + sum2;
            //Console.WriteLine(sum1);
            //Console.WriteLine(sum2);
            //Console.WriteLine(sum3);
            //Console.WriteLine(x);

            ////Arithmetic operaation
            ////+ - Addition
            ////- Subtraction
            ////* - Multiplication
            //// / - Division
            //// % - Modules - returns the division remainder
            //// ++ increment
            ////-- decrement

            //int z = 10;
            //z += 5;
            //Console.WriteLine(z);

            ////assignment operatiord

            ////+=
            ////-=
            ////*=
            /////=
            ////%=
            ////&=
            ////|=
            ////^=
            ////>>=
            ////<<=

            ////comparison operators
            //int d = 5;
            //int c = 3;
            //Console.WriteLine(d > c);

            ////more examples are
            ////== Equal to x == y
            ////!= Not equal x != y
            ////> Greater than x > y
            ////< Less than x<y
            ////>= Greater than or equal to    x >= y
            ////<=

            ////Logical operators
            ////As with comparison operators, you can also test for True or False values with logical operators.

            ////examples are &&- Logical AND, || - Logical OR, ! - Logical NOT



        }
    }



}
