using CSharpTranining._0_FirstSteps;
using System;

namespace CSharpTranining
{
    public class Program
    {
        private const string Question1 = "Hello! What is your name?";
        private const string Question2 = "How old are you?";
        private const string Question3 = "What day of the week?";
        private const string Question4 = " What is your budget?";
        private const string Greeting = "Hello ";
        private static string Answer1;
        private static string Answer2;
        private static string Answer3;
        private static string Answer4;

        public static void Main(string[] args)
        {
            Console.WriteLine(Question1);
            Answer1 = Console.ReadLine();
            Console.WriteLine(Question2);
            Answer2 = Console.ReadLine();
            Console.WriteLine(Question3);
            Answer3 = Console.ReadLine();
            Console.WriteLine(Question4);
            Answer4 = Console.ReadLine();
            int age = int.Parse(Answer2);
            int day = int.Parse(Answer3);
            int budget = int.Parse(Answer4);



            if (age > 0 && age < 99)
            {
                if (age < 16)
                {
                    Console.WriteLine(Greeting + Answer1 + "! Sorry you are too small!");
                }
                else if (age == 17)
                {
                    Console.WriteLine(Greeting + Answer1 + "! You almost reached the age of majority!");
                }
                else
                {
                    Console.WriteLine(Greeting + Answer1 + "! You are old enough to explore our content!");
                }
            }

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday and we are working! Enjoy!");
                    break;
                case 2:
                    Console.WriteLine("Tuesday and we are working! Enjoy!");
                    break;
                case 3:
                    Console.WriteLine("Wednesday and we are working! Enjoy!");
                    break;
                case 4:
                    Console.WriteLine("Thursday and we are working! Enjoy!");
                    break;
                case 5:
                    Console.WriteLine("Friday and we are working! Enjoy!");
                    break;
                case 6:
                    Console.WriteLine("Saturday, sorry this is a day off and we are not working!");
                    break;
                case 7:
                    Console.WriteLine("Sunday, sorry this is a day off and we are not working!");
                    break;

            }

            switch (budget)
            {
                case int n when n >= 0 && n <= 25:
                    Console.WriteLine("Silver subscription may be available for you!");
                    break;
                case int n when n >= 26 && n <= 50:
                    Console.WriteLine("Gold subscription may be available for you!");
                    break;
                case int n when n > 50:
                    Console.WriteLine("Platinum subscription may be available for you!");
                    break;
                default:
                    Console.WriteLine("We do not provide services on credit!");
                    break;
            }

        }
    }
}
