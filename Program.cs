using System;

namespace deliverable2ConditionalStatement_Stewart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Grade Between Do You Expect To Get In ISM4300?");

            try
            {
                string prediction = Console.ReadLine();

                int grade = int.Parse(prediction);

                if ((grade > 97) && (grade < 101))
                {
                    Console.WriteLine("Congratulations You Have an A+");
                }

                else if ((grade > 91) && (grade < 98))
                {
                    Console.WriteLine("Congratulations You have an A");
                }

                else if ((grade > 89) && (grade < 92))
                {
                    Console.WriteLine("Congratulations you have an A-");
                }

                else if ((grade > 87) && (grade < 90))
                {
                    Console.WriteLine("Good Job on a B+");
                }

                else if ((grade > 81) && (grade < 88))
                {
                    Console.WriteLine("Good Job on a B");
                }
                
                else if ((grade > 79) && (grade < 82))
                {
                    Console.WriteLine("Good Job on a B-");
                }

                else if ((grade > 77) && (grade < 80))
                {
                    Console.WriteLine("You have a C+");
                }
                
                else if ((grade >71) && (grade < 78))
                {
                    Console.WriteLine("You have a C");
                }

                else if ((grade > 69) && (grade < 72))
                {
                    Console.WriteLine("You have a C-");
                }

                else if ((grade > 67) && (grade < 70))
                {
                    Console.WriteLine("You have a D+");
                }

                else if ((grade > 61) && (grade < 68))
                {
                    Console.WriteLine("You have a D");
                }

                else if ((grade > 59) && (grade < 62))
                {
                    Console.WriteLine("You have a D-");
                }

                else if  ((grade >= 0 ) && (grade < 60))
                {
                    Console.WriteLine("You have an F, consider dropping the course");
                }

                else
                {
                    Console.WriteLine("error");
                }
                   
            }
            catch
            {
                Console.WriteLine("This is not a valid prediction, please enter a positive integer.");
            }
        }
    }
}
