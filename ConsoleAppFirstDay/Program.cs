using System;

namespace ConsoleAppFirstDay
{
    /*
      Comment block
      alla lines int this are comments
     */

    class Program
    {
        // This is a comment line
        static void Main(string[] args)
        {
            //Gretting();

            //Gretting("Bill");

            bool keepAlive = true;

            while (keepAlive)
            {
                Console.WriteLine("-----Menu-----\n1: Gretting\n2: The Bar\n0: Quit");
                int answer = GetNumberFromUser("selection");

                switch (answer)
                {
                    case 1:
                        Gretting();
                        break;
                    case 2:
                        TheBar();
                        break;
                    case 0:
                        keepAlive = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid selection.");
                        break;
                }

            }
            
        }

        static void Gretting()
        {
            string name = "Ulf";

            Console.WriteLine("Hello! this is " + name + " first code in C# !!!");
        }

        static void Gretting(string name)
        {
            Console.WriteLine("Hello! this is " + name + " first code in C# !!!");
        }

        static int GetNumberFromUser(string forWhat)
        {
            bool work = false;
            int number = 0;

            do
            {
                Console.Write($"Pleace input {forWhat}: ");
                string input = Console.ReadLine();

                work = int.TryParse(input, out number);

                if (!work)
                {
                    Console.WriteLine("This program is unable to read numbers writen as words.");
                }

            } while (!work);

            return number;
        }

        static void TheBar()
        {
            int age = GetNumberFromUser("your age");

            if (age >= 18)
            {
                Console.WriteLine("You may enter the Bar!");
            }
            else
            {
                Console.WriteLine("There is a soda stall around the corner.");
            }
        }


    }// Program ends
}// Namespcae ends
