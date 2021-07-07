using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining._2_Datatypes.ReferenceTypes
{
    public class StringPractice
    {
        
        public static void Run()
        {
            string c = "Test";
            string d = c;

            Console.WriteLine($"Original c value: {c}");
            Console.WriteLine($"Original d value: {d}");

            c = "Not test";

            Console.WriteLine($"c after modification: {c}");
            Console.WriteLine($"d after modification: {d}");


        }
        
    }
}


