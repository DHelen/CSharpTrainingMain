using System;

namespace CSharpTranining.Home_Work
{
    public class _1HomeWork
    {
        public static void Run() 
        {
            string Sentence1 = "Please type a 6 digits number";
            string Answer01;
            int total=0;
            Console.WriteLine(Sentence1);
            Answer01 = Console.ReadLine();
            bool isInt = int.TryParse(Answer01, out int checkint);
            int quantity = Answer01.Length;
            

            if (!isInt)
            { Console.WriteLine("It is Not Integer "); }

            else
            {
                if (quantity != 6)

                { Console.WriteLine("Please check that you enter 6 digits number"); }

                else
                {
                    Console.WriteLine("Lets continue");
                    
                    char[] charArr = Answer01.ToCharArray();

                    int[] amount = new int[6];

                    for (int i = 0 ; i < amount.Length; i++)
                    {
                        amount[i] = int.Parse(charArr[i].ToString());
                    }
                    int sum = 0;
                        for ( int a=0; a< amount.Length/2; a++)
                    {
                        sum = sum + amount[a];
                    }
                    int sum2 = 0;
                    for (int a = 3; a < amount.Length ; a++)
                    {
                        sum2 = sum2 + amount[a];
                    }
                    if (sum == sum2)
                        Console.WriteLine("You have a lucky tiket! Your sum is " + sum);
                    else
                    {
                        Console.WriteLine($"Try again! the sum of the first three numbers is not equal to the sum of the second three digits. There are  " + sum + " and "+ sum2);
                    }

                      

                }
            }    
        }
    }
}
