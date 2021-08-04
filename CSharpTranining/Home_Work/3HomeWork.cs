using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining.Home_Work
{
    public class _3HomeWork
    {
        public static void Run()
        {
            Console.WriteLine("Please enter integer");
            string Answer1 = Console.ReadLine();
           bool  isInt = int.TryParse(Answer1, out int value);
            do
            {
                Console.WriteLine("You've entered a new text of integer type " + value);
                Console.WriteLine("Please enter integer");
                 Answer1 = Console.ReadLine();
                 isInt = int.TryParse(Answer1, out  value);

            }
            while (isInt);           

        }
    }

}
