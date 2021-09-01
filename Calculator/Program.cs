﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keepCalculating = true;

            while (keepCalculating)
            {
                try
                {
                    Console.WriteLine("Enter a calculation method or press E to exit:");
                    Console.WriteLine("- for Subtraction");
                    Console.WriteLine("+ for Addition");
                    Console.WriteLine("* for Multiplication");
                    Console.WriteLine("/ for Division");

                    char calculationChoice = char.Parse(Console.ReadLine());
                
                    switch (calculationChoice)
                    {
                        case '-':
                            RunSubtraction();
                            break;
                        case '+':
                            RunAddition();
                            break;
                        case '/':
                            RunDivision();   
                            break;

                        case '*':
                            RunMultiplication();
                            break;
                        case 'e':
                            keepCalculating = false;
                            Console.WriteLine("Bye!");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid option");
                            break;

                    }
                                       Console.ResetColor();
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid option");
                    Console.ResetColor();
                }

            }
        }//end main

       
        private static void RunSubtraction()
        {
            Console.WriteLine("Subtraction!");
            double num1 = AskUserForNumber("first");
            double num2 = AskUserForNumber("second");
            
            double dif = num1 - num2;

            Console.WriteLine($"{num1} - {num2} = {dif}");

        } 
        private static void RunAddition()
        {
            Console.WriteLine("Addition!");
            double num1 = AskUserForNumber("first");
            double num2 = AskUserForNumber("second");
            double sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");
        } 
        private static void RunDivision() 
        {
            Console.WriteLine("Division!");
            double num1 = AskUserForNumber("first");
            while (num1 == 0)
            {
                Console.WriteLine("The number can't be zero, please type another number.");
                num1 = AskUserForNumber("first");
            }
            double num2 = AskUserForNumber("second");
            while (num2 == 0)
            {
                Console.WriteLine("The number can't be zero, please type another number.");
                num2 = AskUserForNumber("second");
            }
            double quota = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {quota}");
        } 
        
        private static void RunMultiplication()
        {
            Console.WriteLine("Multiplication!");
            double num1 = AskUserForNumber("first");
            double num2 = AskUserForNumber("second");
            double prod = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {prod}");

        }

        static double AskUserForNumber(string order)
        {
            Console.WriteLine($"Enter your {order} number:");
            double num = double.Parse(Console.ReadLine());
            return num;
        }
        
        
      
    }
}
