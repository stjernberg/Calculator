using System;

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
                    char chooseMethod = MenuSelection();
                
                    switch (chooseMethod)
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
                            Console.WriteLine("Good bye!");
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

        static char MenuSelection()
        {
            Console.WriteLine("Enter a calculation method or press e to exit:");
            Console.WriteLine("- for Subtraction");
            Console.WriteLine("+ for Addition");
            Console.WriteLine("* for Multiplication");
            Console.WriteLine("/ for Division");

            char calculationChoice = char.Parse(Console.ReadLine());
            return calculationChoice;
        }
       
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
            if(num1 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The number can't be zero, please type another number.");
                Console.ResetColor();
                num1 = AskUserForNumber("first");
            }

            double num2 = AskUserForNumber("second");
            if (num2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The number can't be zero, please type another number.");
                Console.ResetColor();
                num2 = AskUserForNumber("second");
            }

            double quot = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {quot}");
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
           
            Console.Write($"Enter your {order} number: ");
            string askUserNumber = Console.ReadLine();
            double number;  
           
            while(!double.TryParse(askUserNumber, out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must type a number, please try again!");
                Console.ResetColor();
                askUserNumber = Console.ReadLine();
            }

            return number;

        }     
      
    }
}
