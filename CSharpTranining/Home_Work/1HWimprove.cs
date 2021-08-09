using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining.Home_Work
{
    public class _1HWimprove

    {
        public static void Run()
        {
            string Sentence1 = "Please check that you enter 6 digits number";
            string Answer01;
            int total = 0;
            Console.WriteLine(Sentence1);
            Answer01 = Console.ReadLine();
            bool isInt = int.TryParse(Answer01, out int checkint);
            int quantity = Answer01.Length;
            if (!isInt || quantity != 6)
            { 
         while (isInt == false) 
                {
                    Console.WriteLine(Sentence1);
                    Console.WriteLine("Not integer");
                    Answer01 = Console.ReadLine();
                    bool isInt2  = int.TryParse(Answer01, out int checkint2);
                    Console.WriteLine(isInt2);
                    quantity = Answer01.Length;
                    break;
                  
                }
              while (quantity != 6)
                {
                    isInt = int.TryParse(Answer01, out checkint);
                    Console.WriteLine(Sentence1);
                    Console.WriteLine("Not 6");
                    Answer01 = Console.ReadLine();
                    quantity = Answer01.Length;
                    isInt = int.TryParse(Answer01, out checkint);
                    break;

                }
                Answer01 = Console.ReadLine();
                quantity = Answer01.Length;
                isInt = int.TryParse(Answer01, out checkint);
            }

            else
            {
               
                    Console.WriteLine("Lets continue");

                    char[] charArr = Answer01.ToCharArray();

                    int[] amount = new int[6];

                    for (int i = 0; i < amount.Length; i++)
                    {
                        amount[i] = int.Parse(charArr[i].ToString());
                    }
                    int sum = 0;
                    for (int a = 0; a < amount.Length / 2; a++)
                    {
                        sum = sum + amount[a];
                    }
                    int sum2 = 0;
                    for (int a = 3; a < amount.Length; a++)
                    {
                        sum2 = sum2 + amount[a];
                    }
                    if (sum == sum2)
                        Console.WriteLine("You have a lucky tiket! Your sum is " + sum);
                    else
                    {
                        Console.WriteLine($"Try again! the sum of the first three numbers is not equal to the sum of the second three digits. There are  " + sum + " and " + sum2);
                    }
            }
        }
    

    }
}
