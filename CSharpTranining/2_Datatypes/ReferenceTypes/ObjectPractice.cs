using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTranining._2_Datatypes.ReferenceTypes
{
    public class ObjectPractice
    {
        public static void Run()
        {
          
            var employer1 = new Persons
            {
                FirstName = "David",
                LastName = "Beckham",
                Dob = new DateTime(1975, 5, 02)
            };

            var employer2 = employer1;

            var employee3 = new Persons
            {
                FirstName = "Kostia",
                LastName = "Teltov"
            };

            employee3.Dob = new DateTime(1986, 09, 19);

            Console.WriteLine($"Original employer1 value: {employer1.FirstName} {employer1.LastName} {employer1.Dob.Value.ToShortDateString()}");
            Console.WriteLine($"Original employer2 value: {employer2.FirstName} {employer2.LastName} {employer2.Dob.Value.ToShortDateString()}");

            employer1.LastName = "Giggs";
            employer2.FirstName = "Archy";

            Console.WriteLine($"Update employer1 value: {employer1.FirstName} {employer1.LastName} {employer1.Dob.Value.ToShortDateString()}");
            Console.WriteLine($"Update employer2 value: {employer2.FirstName} {employer2.LastName} {employer2.Dob.Value.ToShortDateString()}");
            Console.WriteLine($"Update employer2 value: {employee3.FirstName} {employee3.LastName} {employee3.Dob.Value.ToShortDateString()}");
        }
    }
}

