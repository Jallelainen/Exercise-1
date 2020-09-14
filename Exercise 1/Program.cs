using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit):");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number.");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number.");
                    Console.ResetColor();
                }

            }


        }


        private static void RunExerciseOne()
            {
            string firstname = "Jamarcus";
            string lastname = "Jarule";

            Console.Clear();

            Console.WriteLine("You've successfully ran exercise One!");
            //Console.Write();
            Console.Write("Hello, " + firstname + " " +  lastname + "! I'm glad to inform you that you are the test subject of my very first assignment!"); 
            Console.WriteLine();

            }

        private static void RunExerciseTwo()
        {
            Console.Clear();
            Console.WriteLine("You've successfully ran exercise Two!");


            var todaysdate = DateTime.Today;
            string format = "dddd d, MMMM, yyyy";
            Console.WriteLine("Todays date is " + todaysdate.ToString(format));// eget format

            var tomorrowsdate = todaysdate.AddDays(1);
            Console.WriteLine("Tomorrows date is " + tomorrowsdate.ToShortDateString());// format short string (DD/MM/YYY)

            var yesterdaysdate = todaysdate.AddDays(-1);
            Console.WriteLine("Yesterdays date was " + yesterdaysdate.ToLongDateString());// format long string (den 13 September, 2020)

        }
        private static void RunExerciseThree()
        {
            string firstname = AskUserFor
        }

    }
}
