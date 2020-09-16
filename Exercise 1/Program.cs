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
                    //Console.ForegroundColor = ConsoleColor.Green;
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
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
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
            int input1;
            int input2;

           
            Console.WriteLine("Please enter a number: ");
            input1 = TextToNumber(Console.ReadLine()); 
            
            
            Console.WriteLine("Please enter a number: ");
            input2 = TextToNumber(Console.ReadLine());


            if (input1 > input2) 
            {
                
                Console.WriteLine(input1 + " is the biggest number.");
                Console.WriteLine(input2 + " is the smallest number.");

                int number1 = input1 - input2;
                Console.WriteLine("The difference is " + number1);

                int number2 = input1 + input2;
                Console.WriteLine("The sum is " + number2);

                int number3 = input1 * input2;
                Console.WriteLine("The product is " + number3);

                int number4 = input1 / input2;
                Console.WriteLine("The ratio is " + number4);
            }
            else
            {
                
                Console.WriteLine(input2 + " is the biggest number.");
                Console.WriteLine(input1 + " is the smallest number.");
                
                int number1 = input2 - input1;
                Console.WriteLine("The difference is " + number1);

                int number2 = input2 + input1;
                Console.WriteLine("The sum is " + number2);

                int number3 = input2 * input1;
                Console.WriteLine("The product is " + number3);
                
                int number4 = input2 / input1;
                Console.WriteLine("The ratio is " + number4);
            }


            static int TextToNumber(string textNumber)
            {
                int number = 0;

                int.TryParse(textNumber, out number);

                return number;
            }


        }

        private static void RunExerciseSeven()
        {
            double input;

            Console.WriteLine("Please enter a number: ");
            input = TextToNumber(Console.ReadLine());

            double area = (3.14 * (input * input));

            double volume = ((4.0 * 3.14 * (input * input * input)) / 3);

            Console.WriteLine("The area is " + area + "m2, and the volume is " + volume + "m3.");


            static double TextToNumber(string textNumber)
            {
                double number = 0.0;

                double.TryParse(textNumber, out number);

                return number;
            }

        }

        private static void RunExerciseEight()
        {
            decimal input;

            Console.WriteLine("Please enter a number: ");
            input = TextToNumber(Console.ReadLine());

            decimal sqrt = (decimal)Math.Sqrt((double)input);
            decimal pow2 = input * input;
            decimal pow10 = (decimal)Math.Pow((double)input, 10);

            Console.WriteLine("The square root of this number is: " + sqrt + "\n" +
                "This number raised to the power of 2 is: " + pow2 + "\n" +
                "This number raised to the power of 10 is: " + pow10);

            static decimal TextToNumber(string textNumber)
            {
                decimal number = 0;

                decimal.TryParse(textNumber, out number);

                return number;
            }

        }

        private static void RunExerciseNine()
        {
            Console.WriteLine("Welcome, what is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName + ", may I ask your year of birth?");
            int userBirthYear = TextToNumber(Console.ReadLine());

            int userAge = DateTime.Now.Year - userBirthYear;


            if (userAge >= 18)
            {
                OrderBeer();   
            }

            else if (userAge < 18)
            {
                OrderCoke();
            }

            static void OrderBeer()
            {
                bool keepLooping;
                do
                {
                    keepLooping = false;

                    Console.WriteLine("Would you like to order a beer?");
                    string answer = Console.ReadLine();

                    if (answer == "yes")
                    {
                        Console.WriteLine("Your order has been served!");
                    }
                    else if (answer == "no")
                    {
                        OrderCoke();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I did not catch that");
                        keepLooping = true;
                    }
                }
                while (keepLooping);
            }

            static void OrderCoke()
            {
                bool keepLooping;
                do
                {
                    keepLooping = false;

                    Console.WriteLine("Would you like to order a Coke?");
                    string answer = Console.ReadLine();

                    if (answer == "yes")
                    {
                        Console.WriteLine("Your order has been served!");
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("There are unfortunantely no other alternatives.");
                        answer = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I did not catch that");
                        keepLooping = true;
                    }
                }
                while (keepLooping);

            }

            static int TextToNumber(string textNumber)
            {
                int number = 0;

                int.TryParse(textNumber, out number);

                return number;
            }
        }

        private static void RunExerciseTen()
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {

                    
                    Console.WriteLine("Choose between option 1, 2, or 3, or -1 if you want to go back");
                    var optionChoice = int.Parse(Console.ReadLine() ?? "");
                    switch (optionChoice)
                    {
                        case 1:
                            Division();
                            break;
                        case 2:
                            RunExerciseFour();
                            break;
                        case 3:
                            ColorChange();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number.");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number.");
                    Console.ResetColor();
                }
            }

            static void Division()
            {
                double numberOne;
                double numberTwo;
                double divisionResult;

                Console.WriteLine("Please enter a number:");
                numberOne = TextToNumber(Console.ReadLine());

                Console.WriteLine("Please enter the number that you wish to divide by: ");
                numberTwo = TextToNumber(Console.ReadLine());

                if (numberTwo == 0.0)
                {
                    Console.WriteLine("I'm sorry, you can not divide by zero. Please try another number:");
                    numberTwo = TextToNumber(Console.ReadLine());
                }

                divisionResult = numberOne / numberTwo;

                Console.Write("That divides to: " + divisionResult);
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();

                static double TextToNumber(string textNumber)
                {
                    double number = 0.0;

                    double.TryParse(textNumber, out number);

                    return number;
                }
            }

            static void ColorChange()
            {
                
                if (Console.ForegroundColor == ConsoleColor.Green)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (Console.ForegroundColor == ConsoleColor.Magenta)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                
            }
   

        }
    }
}
