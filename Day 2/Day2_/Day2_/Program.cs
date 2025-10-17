//c# syntax
using System; //means we can use classes from the system namespace
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

//namespace is a container to organize your code and its a container for classes and other namespaces
namespace HelloWorld
{
    // A class is a container for data and methods which brings functionaality to your program
    class Program
    {
        //Another thing that always appear in a C# program is the Main method. Any code inside its curly brackets {}
        static void Main(string[] args)
        {
            // Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");

            //c# output
            //mathematical calculations:
            Console.WriteLine(3 + 3);

            //write method
            //This is similar to WriteLine. The only difference is that it does not insert a new line at the end of the output:
            Console.Write("Hello world ");


            //multi-line comments

            /* The code below will print the words Hello World
               to the screen, and it is amazing */

            //variables
            //Variables are containers for storing data values.

            //Types
            /* int -stores integers(whole numbers), without decimals, such as 123 or - 123
            double -stores floating point numbers, with decimals, such as 19.99 or - 19.99
            char -stores single characters, such as 'a' or 'B'.Char values are surrounded by single quotes
            string -stores text, such as "Hello World".String values are surrounded by double quotes
            bool -stores values with two states: true or false */


            string username = "Emmanuel";
            Console.WriteLine(username);

            int age = 29;
            Console.WriteLine(age);

            double myDoubleNum = 5.99D;
            Console.WriteLine(myDoubleNum);
            char myLetter = 'D';
            Console.WriteLine(myLetter);
            bool myBool = true;
            Console.WriteLine(myBool);

            //c# constants
            const int myNumber = 5;
            //myNumber = 30; //error cause its already decleared as a constant

            //Display variables
            string name = "John";
            Console.WriteLine("Hello" + " " + name); //The + is used to concatinate

            string firstname = "Emmanuel";
            string lastname = "Oyegunle";

            Console.WriteLine(firstname + " " + lastname);

            //add numeric values
            int a = 5;
            int b = 10;
            Console.WriteLine(a + b);

            //Declare many variables
            int x = 4, y = 5 , z = 10;
            Console.WriteLine(x + y + z);







        }
    }
}