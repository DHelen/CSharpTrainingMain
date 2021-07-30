using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining._4_Loop
{
    public class ForLoop
    {
        static public void Run()
        {
            int[] arrayOfIntegers = new int[5];
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.WriteLine($"the {i + 1}th element of the array is  arrayOfIntegers {i}");
            }

            Console.WriteLine("_______________________________");

            for (int i = arrayOfIntegers.Length; i >= 0; i--)
            {
               Console.WriteLine($"the {i + 1}th element of the NEXT array is  arrayOfIntegers {i}");
            }

            Console.WriteLine("_______________________________");

           int[] arrayOfIntegers2 = new int[7];

            for (int a = 0; a < arrayOfIntegers2.Length; a++)
            {
                arrayOfIntegers2[a] = a + 1;
              Console.WriteLine($" arrayOfInteger elemet {a} is {a}");
            }
            Console.WriteLine("_______________________________");

            int[] arrayOfInteger3 = new int[20];
            for (int i = 0; i < arrayOfInteger3.Length; i++)
            {
                if (arrayOfInteger3[i] % 2 == 0)
                 Console.WriteLine($"arrayOfInteger3 element {i} is Odd number");
            }
        }
    }
}
