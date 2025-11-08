using System;
using System.Reflection.Metadata.Ecma335;

namespace MyApplication
{

    class StudentApp
    {

        Students student = new Students();
        Admin admin = new Admin();



        public void Menus()
        {
           
                Console.WriteLine("===WELCOME TO OUR STUDENT APP===");
                string email = admin.Email;
                if (email != null)
            {
                student.Login();
            }
            else
            {
                student.register();
            }

                while (!student.isAuthenticated())
                {
                    Console.WriteLine("You must login to continue");
                    student.Login();
                }

            while (true)
            {

                Console.WriteLine("\n====== STUDENT MENUS ======");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. View All Student");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                int picked_value;
                bool valid = int.TryParse(Console.ReadLine(), out picked_value);

                if (!valid)
                {
                    Console.WriteLine("Please pick a valid number from the menu");
                    continue;

                }

                switch (picked_value)
                {
                    case 1:
                        student.AddStudent();
                        break;
                    case 2:
                        student.RemoveStudents();
                        break;
                    case 3:
                        student.ViewAllStudents();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using our student app...Goodbye!!");
                        break;
                    default:
                        Console.WriteLine("Invalid number... Please Put in a valid number");
                        break;
                }
                MustRun();
            }
        }

        public void MustRun()
        {
            Console.WriteLine("\nPress ENTER to return to Menu...");
            student.isAuthenticated();
            Console.ReadLine();
            Console.Clear();
        }

    }


}
