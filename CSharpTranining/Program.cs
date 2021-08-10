using CSharpTranining._0_FirstSteps;
using CSharpTranining._1_ConsoleAppAndIfStatements;
using CSharpTranining._2_Datatypes.ReferenceTypes;
using CSharpTranining._2_Datatypes.ValueTypes;
using CSharpTranining._3_Arrays;
using CSharpTranining._4_Loop;
using CSharpTranining.Home_Work;
using System;

namespace CSharpTranining
{
    public class Program2
    {

        private const string Question1 = "What lesson number you are interested in? :";
        private const string Question2 = "What type of data are you interested in ( 1. Referense 2. Value)? Please write the number ";
        private const string Question3 = "What would you like to choose 1.Object or 2.String?";
        private const string Question4 = "What would you like to choose: 1.Boolean, 2.Char, 3.Decimal, 4.Double, 5.Float 6.Integer 7.Long 8.Short?  Please write the number ";
        private const string Question5 = "What HW would you like to choose: 1,2,3,4?";
        private const string NoSuchCaseMessage = "No such case. Please make sure you've selected correct item number";
        private const string NotIntegerMessage = "Answer should be in Integer";
        private static string Answer1;
        private static string Answer2;
        private static string Answer3;
        private static string Answer4;
        private static string Answer5;
        public static void Main(string[] args)
        {
           
            Console.Clear();
            Console.WriteLine(Question1);
            Answer1 = Console.ReadLine();
            bool isInt = int.TryParse(Answer1, out int lesson);

            if (!isInt)
                Console.WriteLine(NotIntegerMessage);
            else
            {
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
                        bool isInt2 = int.TryParse(Answer2, out int type);
                        //int type = int.Parse(Answer2);
                        if (!isInt2)
                            Console.WriteLine(NotIntegerMessage);
                        else
                        {
                            switch (type)
                            {
                                case 1:
                                    Console.WriteLine("You selected Reference Types!");
                                    Console.WriteLine(Question3);
                                    Answer3 = Console.ReadLine();
                                    bool isInt3 = int.TryParse(Answer3, out int reftype);
                                    //int reftype = int.Parse(Answer3); 

                                    if (!isInt3)
                                        Console.WriteLine(NotIntegerMessage);
                                    else {
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
                                            default:
                                                Console.WriteLine(NoSuchCaseMessage);
                                                break;
                                        }
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("You selected Value Types!");
                                    Console.WriteLine(Question4);
                                    Answer4 = Console.ReadLine();
                                    bool isInt4 = int.TryParse(Answer4, out int datatype2);
                                    //int datatype2 = int.Parse(Answer4);

                                    if (!isInt4)
                                        Console.WriteLine(NotIntegerMessage);
                                    else { 

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
                                            default:
                                                Console.WriteLine(NoSuchCaseMessage);
                                                break;

                                        } }
                                    break;
                                default:
                                    Console.WriteLine(NoSuchCaseMessage);
                                    break;
                            }
                         }
                        break;
                    case 4:
                        Console.WriteLine("You selected the Fourth Lesson!");
                        SingleArrays.Run();
                        break;
                    case 5:
                        Console.WriteLine("You selected the Fifth Lesson!");
                        ForLoop.Run();
                        ForLoopRundom.RunForLoop();
                        break;
                    case 6:
                        Console.WriteLine("You selected the Home Works!");
                        Console.WriteLine(Question5);
                        Answer5 = Console.ReadLine();
                        bool isIntcheck = int.TryParse(Answer5, out int hwnum);
                        if (!isIntcheck)
                            Console.WriteLine(NotIntegerMessage);
                        else
                        {
                            switch (hwnum)
                            {
                                case 1:
                                    Console.WriteLine("You choosed LuckyNumber");
                                    _1HomeWork.Run();
                                    //_1HWimprove.Run();
                                    break;
                                case 2:
                                    Console.WriteLine("You choosed List");
                                    _2HomeWork.RunGetMoviesFromAustralia();
                                    break;
                                case 3:
                                    Console.WriteLine("You choosed DoWhile");
                                    _3HomeWork.Run();
                                    break;
                                case 4:
                                    Console.WriteLine("You choosed Calculator");
                                   _4HomeWork.Run();
                                    break;
                            } 
                        }
                        break;
                    default:
                        Console.WriteLine(NoSuchCaseMessage);
                        break;
                }
            }
        }
        

    }







}

