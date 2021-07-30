using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining._4_Loop
{
   public  class ForLoopRundom
    {
            public static void RunForLoop()
            {
           
                //Random class. Generates random numbers
                var random = new Random();
            
                int[] arrayOfIntegers = new int[random.Next(5, 20)];



                //Looping with increment and assign values
                for (int i = 0; i < arrayOfIntegers.Length; i++)
                {
                    arrayOfIntegers[i] = random.Next(0, 200);
                    if (i == arrayOfIntegers.Length - 1)
                        Console.WriteLine();
                }



                //Looping with decrement and read values starting from the last element
                for (int i = arrayOfIntegers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"{nameof(arrayOfIntegers)} element {i} is equal to {arrayOfIntegers[i]}");
                }



                //Logic inside of the loop. Checking if value is Odd number
                Console.WriteLine();
                for (int i = 0; i < arrayOfIntegers.Length; i++)
                {
                    if (arrayOfIntegers[i] % 2 == 0)
                    
                        Console.WriteLine($"arrayOfIntegers element {i} is Odd number");
                }

            Console.WriteLine();

            int[] forloopRundom = new int[random.Next(15)];

            for ( int a =0; a < forloopRundom.Length; a++)
            {
                forloopRundom[a] = random.Next(25);
                Console.WriteLine(forloopRundom[a]);
            }

            Console.WriteLine();
            Console.WriteLine("reversedloop:\n");

            int[] reversedforloopRundom = new int[forloopRundom.Length];
            
            for ( int a =0, j=forloopRundom.Length-1; a< reversedforloopRundom.Length; a++)
            {
                reversedforloopRundom[a] = forloopRundom[j];
                j--;
                Console.WriteLine(reversedforloopRundom[a]);
            }

        }

    }
}
