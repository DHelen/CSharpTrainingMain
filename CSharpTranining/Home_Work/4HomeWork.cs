using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining.Home_Work
{
    public class _4HomeWork
    {
        private const string NotIntegerMessage = "Value  should be in Integer";
        private const string Q1 = "Please Enter  first value";
        private const string Q2 = "Please Enter  enter operation name: + or - or * or  / ";
        private const string Q3 = "Please Enter  second value";
        private static string Answer1;
        private static string Answer2;
        private static string Answer3;
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine(Q1);
            Answer1 = Console.ReadLine();
            bool isInt = int.TryParse(Answer1, out int firstvalue);

            while (!isInt)
            {
                Console.WriteLine(NotIntegerMessage);
                Console.WriteLine(Q1);
                Answer1 = Console.ReadLine();
                isInt = int.TryParse(Answer1, out  firstvalue);

            }
            Console.WriteLine(Q3);
            Answer3 = Console.ReadLine();
            bool isInt2 = int.TryParse(Answer3, out int secondvalue);
            while (!isInt2)
            {
                Console.WriteLine(NotIntegerMessage);
                Console.WriteLine(Q3);
                Answer3 = Console.ReadLine();
                isInt2 = int.TryParse(Answer3, out  secondvalue);
            }
            bool g = false;
            int sum = 0;
            while(g == false) 
                    {
                        Console.WriteLine(Q2);
                        Answer2 = Console.ReadLine();
                        if (Answer2 == "+")
                        { sum = firstvalue + secondvalue;
                            Console.WriteLine("The sum " + firstvalue + " and " + secondvalue + " is " + sum);
                            g = true; }
                        else
                        {
                            if (Answer2 == "-")
                            { sum = firstvalue - secondvalue;
                                Console.WriteLine("The difference " + firstvalue + " and " + secondvalue + " is " + sum);
                                g = true; }
                            else
                            {
                                if (Answer2 == "*")
                                {
                                    sum = firstvalue * secondvalue;
                                    Console.WriteLine("The product of " + firstvalue + " and " + secondvalue + " is " + sum);
                                    g = true;
                                }
                                else
                                {
                                    if (Answer2 == "/")
                                    {
                                        sum = firstvalue / secondvalue;
                                        Console.WriteLine("The quotient of " + firstvalue + " and " + secondvalue + " is " + sum);
                                        g = true;
                                    }
                                    else
                                    {
                                        g = false;
                                    }
                                }

                            }

                    

                }
                   
            }
        }
    }
}
