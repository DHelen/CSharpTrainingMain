using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining.Home_Work
{
    public class _4HomeWork
    {
        private const string NotIntegerMessage = "Value  should be in Decimal ";
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
            bool isDec = decimal.TryParse(Answer1, out decimal firstvalue);

            while (!isDec)
            {
                Console.WriteLine(NotIntegerMessage);
                Console.WriteLine(Q1);
                Answer1 = Console.ReadLine();
                isDec = decimal.TryParse(Answer1, out  firstvalue);

            }
            Console.WriteLine(Q3);
            Answer3 = Console.ReadLine();
            bool isDec2 = decimal.TryParse(Answer3, out decimal secondvalue);
            while (!isDec2)
            {
                Console.WriteLine(NotIntegerMessage);
                Console.WriteLine(Q3);
                Answer3 = Console.ReadLine();
                isDec2 = decimal.TryParse(Answer3, out  secondvalue);
            }
            bool g = false;
            decimal sum = 0;
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
