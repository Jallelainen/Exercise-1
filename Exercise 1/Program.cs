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
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
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
            string firstname = AskUserFor("firstname");
            string lastname = AskUserFor("lastname");

            string fullName = CombineFirstAndLastNameIntoFullName(firstname, lastname);

            Console.WriteLine("Your full name is: " + fullName);

        static string AskUserFor(string whatfor)
        {
            Console.Write("Please enter " + whatfor + ": ");
            string userInput = Console.ReadLine();

            return userInput;
        }

        static string CombineFirstAndLastNameIntoFullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;

            return fullName;
        }

        }

        private static void RunExerciseFour()
        {
            String str = "The quick fox Jumped Over the DOG";

            str = str.Remove(4, 6); // The fox Jumped Over the DOG
            
            str = str.Insert(3, " brown"); // The brown fox Jumped Over the DOG
            
            string dog = str.Replace("DOG", "lazy dog");//The brown fox Jumped Over the lazy dog

            string index1 = dog.Substring(14, 1); //index1 = "J"
            string index2 = dog.Substring(21, 1); //index2 = "O"

            string final = dog.Replace(index1, "j");
            final = final.Replace(index2, "o"); //The brown fox jumped over the lazy dog

 
            //string final = dog.Replace("Jumped Over", "jumped over");

            Console.WriteLine(final);

        }

        private static void RunExerciseFive()
        {
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";

            int i = str.IndexOf("[");// location of "["
            string numbers = str.Substring(i);//numbers = [1,2,3,4,5]

            numbers = numbers.Remove(3, 4); // removes "2,3,". Result: [1,4,5]

            string finalOutput = numbers.Insert(6, ",6,7,8,9,10");

            Console.WriteLine(finalOutput);
        }

        private static void RunExerciseSix()
        {
            throw new NotImplementedException();
        }
    }
}
