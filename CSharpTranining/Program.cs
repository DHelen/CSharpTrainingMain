using System;

namespace CSharpTranining
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Variable declaration
            string value;

            //Assign Variable
            value = " Have a nice day!";

            //Print Variable
            Test.HelloName("Elena" + value);

            //Assign new value for Variable
            value = "Starting Calculation";

            //Print new value
            Console.WriteLine(value);

            //Calculate a sum from our new method
            Console.WriteLine(Sum(2, 3));
        }

        public static int Sum (int value1, int value2)
            {
            return value1 + value2;
             }
    }
}
