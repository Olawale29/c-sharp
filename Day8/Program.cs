using System;
using System.IO;

//Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance

namespace MyApplication
{
    //An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
    enum Level {
        Low,
        Medium,
        High
    

    }

    enum Months
    {
        January,    // 0
        February,   // 1
        March=8, //You can also assign your own enum values but without assigning a value it is going to be equals to  // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July       //6
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal Pig = new Pig();
            Animal Dog = new Dog();

           Lion lion = new Lion();
            lion.AnimalSound();
            lion.sleep();


            animal.AnimalSound();
            Pig.AnimalSound();
            Dog.AnimalSound();

            Chicken chicken = new Chicken();

            chicken.AnimalSound();

            DemoClass demoClass = new DemoClass();
            demoClass.myMethod();
            demoClass.myOtherMethod();

            Level myLevel = Level.Medium;
            switch (myLevel)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;

            }

            int myMonth = (int)Months.April;
            Console.WriteLine(myMonth);

            //c# File
            string WriteText = "Hello world";
            File.WriteAllText("hello_world.txt", WriteText);

            string readText = File.ReadAllText("hello_world.txt");
            Console.WriteLine(readText);

            checkAge(20);

            //c# Exceptions
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally { Console.WriteLine("The try and catch has finished"); }

            

        }

        static void checkAge(int Age)
        {
            if (Age < 18)
            {
                throw new ArithmeticException("Access denied you must be at least 18 years old");
            }
            else
            {
                Console.WriteLine("Access granted -  You are old enough");
            }
        }
    }


    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says wee: wee");
        }
    }

    class Dog : Animal
    { 
        public override void AnimalSound()
        {
            Console.WriteLine("The Dog says: bow bow");
        }
    
    }

    //Data abstraction is the process of hiding certain details and showing only essential information to the user.

    abstract class Animals
    {
        public abstract void AnimalSound();

        public void sleep()
        {
            Console.WriteLine("Zzz");
        }


    }

    class Lion : Animals
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The lion says: GRRRRRRRRR");
        }
    }

    //An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):

    interface IAnimals
    {
        void AnimalSound();
    }

    class Chicken: IAnimals
    {
        public void AnimalSound()
        {
            Console.WriteLine("The chicken says COCUROKU");
        }
    }

    interface IFirstInterrface {
        void myMethod();
    
    }

    interface ISecondInterface
    {
        void myOtherMethod();
    }

    class DemoClass : IFirstInterrface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text");

        }

        public void myOtherMethod()
        {
            Console.WriteLine("Some other text");
        }
    }



}
