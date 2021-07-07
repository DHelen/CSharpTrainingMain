using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining._2_Datatypes.ValueTypes
{
   public  class DecimalPractice
    {
        public static void Run()
        {
            decimal price = 99.99M;
            decimal price2 = 45.55M;
            decimal totalPrice = price + price2;

            Console.WriteLine(totalPrice);
        }
    }
}
