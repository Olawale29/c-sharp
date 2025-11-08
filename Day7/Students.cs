using System;
using System.Security.Cryptography;


namespace MyApplication
{


    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public string Matric { get; set; }
    }

    class Admin {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }



    class Students
    {
        public bool isAunthenticate { get; set; }
        private string user_email = "oyegunleemmanuel39@gmail.com";
        private string user_password = "1234567890";
        //public bool isAunthenticate = false;

        private List<Student> students = new List<Student>();
        private List<Admin> admins = new List<Admin>();

        public void AddStudent()
        {
            Student student = new Student();
            Console.WriteLine("Please what is your name ");
            student.Name = Console.ReadLine();
       
            Console.WriteLine("Please what is your age ");
            student.Age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What is your department ");
            student.Department = Console.ReadLine();

            student.Matric = "MAT" + new Random().Next(1000, 9999);

            students.Add(student);

            Console.WriteLine($"{student.Name} is added successfully and matric number is {student.Matric}");

        }

        public void RemoveStudents()
        {
            Console.WriteLine("What is your matric number ");

            string matric = Console.ReadLine();

            Student StudentToRemove = students.Find(s => s.Matric == matric);

            if(StudentToRemove != null)
            {   
                students.Remove(StudentToRemove);
                Console.WriteLine($"Student with matric number {matric} is successfully removed");
            }
            else
            {
                Console.WriteLine("Matric number not found");
            }

        }

        public void ViewAllStudents()
        {
            if(students.Count == 0)
            {
                Console.WriteLine("No Student Found");
                return;
            }
            Console.WriteLine("--Student List--");

            foreach(var  student in students)
            {
                Console.WriteLine($"Student Name {student.Name} | Student Age {student.Age} | Student Department {student.Department} | Student Matric Number {student.Matric}");
            }
        }

        public void Login()
        {
            isAunthenticate = false;

            Console.WriteLine("==YOU NEED TO LOGIN BEFORE YOU ACCESS OUR STUDENT APP==");

            Console.WriteLine("What is your email ");
            string email = Console.ReadLine();

            Console.WriteLine("What is your password ");
            string password = Console.ReadLine();

            Admin admin = new Admin();
            string person_email = admin.Email;
            string person_password = admin.Password;


            if (email != person_email || password != person_password)
            {
                Console.WriteLine("Email or password incorrect");
                isAunthenticate = false;
                return;
            }
            else
            {
                isAunthenticate = true;
                Console.WriteLine("Login successful");
            }

        }

        public bool isAuthenticated()
        {
            return isAunthenticate;
        }

        public void logout()
        {
            isAunthenticate=false;
            Console.WriteLine("You have successfully logged out");
        }

        public void register()
        {
            Admin admin = new Admin();
            Console.WriteLine("What is your username");
            admin.Username  = Console.ReadLine();
            Console.WriteLine("What is your email ");
            admin.Email = Console.ReadLine();
            Console.WriteLine("What is your password ");
            admin.Password = Console.ReadLine();

            admins.Add(admin);

            Console.WriteLine("You have successfully registered");



        }





    }


}
