using System;

namespace MyApplication
{

    class Test
    {

        public void CalculateScore()
        {
            int score = 0;
            Console.WriteLine("What is your mathematics score ");
            score += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your English score ");
            score += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your civic score ");
            score += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your goverment score ");
            score += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your computer score ");
            score += Convert.ToInt32(Console.ReadLine());


            int average = score / 5;
            string grade = "";

            if(average >= 70 && average <= 100)
            {
                grade = "A";
            }else if(average >= 60 && average <= 69)
            {
                grade = "B";
            }else if(average >= 50 && average <= 59)
            {
                grade = "C";
            }else if( average >= 40 && average <= 49)
            {
                grade = "D";
            }else
            {
                grade = "F";
            }

            Console.WriteLine($"Your averge score is {average}");
            Console.WriteLine($"Your grade is {grade}");
         




        }

    }


}
