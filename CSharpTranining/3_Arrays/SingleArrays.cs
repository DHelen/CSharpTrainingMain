using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining._3_Arrays
{
   public  class SingleArrays
    {
        static public void Run()
        {
            //Declaration and initialization
            int[] arrayOfIntegers = new int[5];
            arrayOfIntegers[0] = 5;
            arrayOfIntegers[1] = 7;
            arrayOfIntegers[4] = 8;

            Console.WriteLine("arrayOfInteger is " + arrayOfIntegers.Length);
            Console.WriteLine("array third element is " + arrayOfIntegers[2]);
            Console.WriteLine("array last element is " + arrayOfIntegers[arrayOfIntegers.Length - 1]);
            
            //Declaration, initialization and assignment (With array length)
            string[] arrayOfStrings2 = new string[2] { "Testing", "Development" };
            Console.WriteLine("the first element in the string array is " + arrayOfStrings2[0]);

            //Declaration, initialization and assignment (Without array length. It will be created automatically)
            bool[] arrayOfBooleans3 = new[] { true, false, false, true };
            Console.WriteLine("the last element of the bool array is " + arrayOfBooleans3[arrayOfBooleans3.Length - 1]);

            int[] arrayforloop = new int[20];

            for ( int i = 0; i <arrayforloop.Length; i++)
            {
                arrayforloop[i] = i;
                //Console.WriteLine(arrayforloop[i]);
                if (arrayforloop[i] % 2 == 0)
                    Console.WriteLine($"{i} element is odd number");
                
            }
            

        }
    }
}
