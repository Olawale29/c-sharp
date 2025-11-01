using Oop;
using System;
using System.Drawing;

//Object - oriented programming has several advantages over procedural programming:

//OOP is faster and easier to execute
//OOP provides a clear structure for the programs
//OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
//OOP makes it possible to create full reusable applications with less code and shorter development time

//So, a class is a template for objects, and an object is an instance of a class.

//When the individual objects are created, they inherit all the variables and methods from the class.

namespace Oop
{
    class Program { 
        //string color = "red";
        //string brand = "volvo";

        static void Main(string[] args)
        {
            Car car = new Car("Mustung");
            Console.WriteLine(car.color);

            MyClass myObj = new MyClass();
            myObj.maxSpeed = 100;
            Car Ford = new Car("Toyota");
            Ford.color = "yellow";
            Ford.year = 1920;

            Car Opel = new Car("Aunda");
            //Opel.model = "Astra";
            Opel.color = "green";
            Opel.year = 2025;
            Console.WriteLine(myObj.maxSpeed);
            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Opel.model);
            myObj.fullThrottle();

            Person myPerson = new Person();
            string value = myPerson.Name;
            //myPerson.Name = "David";
            Console.WriteLine(myPerson.Name);





            //Car car2 = new Car();
            //car2.color = "blue";
            //Console.WriteLine(car2.color);  

            //Car car3 = new Car();
            //Console.WriteLine(car3.brand);
        }
    
    }


}
