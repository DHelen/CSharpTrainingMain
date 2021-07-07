using CSharpTranining._0_FirstSteps;
using CSharpTranining._1_ConsoleAppAndIfStatements;
using CSharpTranining._2_Datatypes.ReferenceTypes;
using CSharpTranining._2_Datatypes.ValueTypes;
using System;

namespace CSharpTranining
{
    public class Program2
    {

        private const string Question1 = "What lesson number you are interested in 1,2,3 ?";
        private const string Question2 = "What type of data are you interested in ( 1. Referense 2. Value)? Please write the number ";
        private const string Question3 = "What would you like to choose 1.Object or 2.String?";
        private const string Question4 = "What would you like to choose: 1.Boolean, 2.Char, 3.Decimal, 4.Double, 5.Float 6.Integer 7.Long 8.Short?  Please write the number ";
        private static string Answer1;
        private static string Answer2;
        private static string Answer3;
        private static string Answer4;
        public static void Main(string[] args)
        {
            Console.WriteLine(Question1);
            Answer1 = Console.ReadLine();
            int lesson = int.Parse(Answer1);


            switch (lesson)
            {
                case 1:
                    Console.WriteLine("You selected the First Lesson!");
                    BasicofCSharp.BasicCsharpRun();
                    break;
                case 2:
                    Console.WriteLine("You selected the Socond Lesson!");
                    IfElseSwitch.Run();
                    break;
                case 3:
                    Console.WriteLine("You selected the Third Lesson!");
                    Console.WriteLine(Question2);
                    Answer2 = Console.ReadLine();
                    int type = int.Parse(Answer2);

                    switch (type) 
                    {
                        case 1:
                            Console.WriteLine("You selected Reference Types!");
                            Console.WriteLine(Question3);
                            Answer3 = Console.ReadLine();
                            int reftype = int.Parse(Answer3);

                            switch (reftype)
                            {
                                case 1:
                                Console.WriteLine("You selected Object Practice!");
                                ObjectPractice.Run();
                                    break;
                                case 2:
                                Console.WriteLine("You selected String Practice!");
                                StringPractice.Run();
                                    break;
                            }

                            break;
                        case 2:
                            Console.WriteLine("You selected Value Types!");
                            Console.WriteLine(Question4);
                            Answer4 = Console.ReadLine();
                            int datatype2 = int.Parse(Answer4);

                            switch (datatype2)
                            {
                                case 1:
                                    Console.WriteLine("You selected Boolean Types!");
                                    BooleanPractice.Run();
                                    break;
                                case 2:
                                    Console.WriteLine("You selected Char Types!");
                                    CharPractice.Run();
                                    break;
                                case 3:
                                    Console.WriteLine("You selected Decimal Types!");
                                    DecimalPractice.Run();
                                    break;
                                case 4:
                                    Console.WriteLine("You selected Double Types!");
                                    DoublePractice.Run();
                                    break;
                                case 5:
                                    Console.WriteLine("You selected Float Types!");
                                    FloatPractice.Run();
                                    break;
                                case 6:
                                    Console.WriteLine("You selected Integer Types!");
                                    IntegerPractice.Run();
                                    break;
                                case 7:
                                    Console.WriteLine("You selected Long Types!");
                                    LongPractice.Run();
                                    break;
                                case 8:
                                    Console.WriteLine("You selected Short Types!");
                                    ShortPrectice.Run();
                                    break;

                            }
                            break;
                    }

                    break;
    
            }
        }
        

    }







}

