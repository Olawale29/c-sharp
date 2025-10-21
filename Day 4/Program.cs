using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# math
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(20, 50));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.978));
            Console.WriteLine(Math.Round(9.99));

            //C# strings
            string greetings = "Hello";
            string greetings2 = "Nice to meet you";

            string txt = "ABCDEFGHIJKLMIOPQRSTUVWZYZ";
            Console.WriteLine($"The length of the text is {txt.Length}");

            //There are many string methods available, for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:
            Console.WriteLine(greetings.ToUpper());
            Console.WriteLine(greetings2.ToUpper());

            //string concatination
            string firstname = "Oyegunle ";
            string lastname = "Emmanuel";
            string name = firstname + lastname;
            Console.WriteLine(name);

            //string.Concat
            string first_name = "Oyegunle ";
            string last_name = "Emmanuel";
            string full_name = String.Concat(first_name, last_name);
            Console.WriteLine(full_name);

            int a = 10;
            int b = 20;
            int c = a + b;  // c will be 30 (an integer/number)

            string x = "10";
            string y = "20";
            string z = x + y;  // z will be 1020 (a string)

            //string interpolation
            string firstName = "John";
            string lastName = "Doe";
            string fullName = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(fullName);

            //Access string
            //string myString = "Hello";
            //Console.WriteLine(myString.IndexOf("e"));

            string myString = "Hello";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString.IndexOf("e"));


            string user_name = "John Doe";

            // Location of the letter D
            int charPos = user_name.IndexOf("D");

            // Get last name
            string last_names = name.Substring(charPos);

            // Print the result
            Console.WriteLine(last_names);


            //c# special characters
            string txts = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txts);

            string text = "It\'s alright.";
            Console.WriteLine(text);

            string texts = "The character \\ is called backslash.";
            Console.WriteLine(texts);

            //c# booleans
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);
            Console.WriteLine(10 > 9);

            //int myAge = 25;
            //int votingAge = 18;
            //Console.WriteLine(myAge >= votingAge);

            int myAge = 17;
            int votingAge = 18;

            if (myAge >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }

            //If else
            int m = 20;
            int n = 18;
            if (m > n)
            {
                Console.WriteLine("m is greater than n");
            }

            //int time = 20;
            //if (time < 18)
            //{
            //    Console.WriteLine("Good day.");
            //}
            //else
            //{
            //    Console.WriteLine("Good evening.");
            //}

            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            //shot hand
            int times = 20;
            string result = (times < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            //switch cases
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            int dayx = 4;
            switch (dayx)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }

            //while loop

            //int i = 0;
            //while(i< 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //do-while

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 5);

            //for (int i = 1; i <= 11; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}

            //nested loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }

            string[] cars = {"volvo", "tesla", "BMW", "Mazda"};
            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }

            //break statement
            //for(int i = 0; i < 10; i++)
            //{
            //    if(i == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            int s = 0;
            while(s < 10)
            {
                Console.WriteLine(s);
                s++;

                if(s == 4)
                {
                    break;
                }
            }

            int d = 0;
            while(d < 10)
            {
                Console.WriteLine(d);
                d++;
                if(d == 4)
                {
                    continue;
                }
            }


            string car1 = "Volvo";
            string car2 = "BMW";
            string car3 = "Ford";

            string[] carX = {car1, car2, car3};
            Console.WriteLine(carX[0]);


            //Arrays hold multiple values of the same type.

            //They are indexed starting from 0.

            //Use.Length to get the number of items.

            //Loop through them with for or foreach.

        }
    }
}