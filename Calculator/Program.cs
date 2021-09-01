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

                Console.Write("Enter a calculation method: +, -, / or * (or e to exit): ");
                char calculationChoice = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter the first number: ");

                int num1 = int.Parse(Console.ReadLine());
                while (calculationChoice == '/' && num1 == 0)
                {
                    Console.WriteLine("The number can't be zero, please pick another number.");
                    num1 = int.Parse(Console.ReadLine());
                }
                
                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                while (calculationChoice == '/' && num2 == 0)
                {
                    Console.WriteLine("The number can't be zero, please pick another number.");
                    num2 = int.Parse(Console.ReadLine());
                }


                try
                {
                    switch (calculationChoice)
                    {
                        case '-':
                            RunSubtraction(num1, num2);
                            break;
                        case '+':

                            RunAddition(num1, num2);
                            break;
                        case '/':
                            if (num1 == 0 || num2 == 0)
                            {
                                
                            }
                            else { 
                            RunDivision(num1, num2);   
                            }
                            break;

                        case '*':
                            RunMultiplication(num1, num2);
                            break;
                        case 'e':
                            keepCalculating = false;
                            break;
                        default:
                            Console.WriteLine("That is not a valid option");
                            break;

                    }
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("That is not a valid option");
                }

            }
        }//end main

        private static void RunSubtraction(int num1, int num2)
        {
            Console.WriteLine("Subtraction!");
           
            int dif = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {dif}");

        } 
        private static void RunAddition (int num1, int num2)
        {
            
            Console.WriteLine("Addition!");

            int sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");
        } 
        private static void RunDivision(int num1, int num2) 
        {
            Console.WriteLine("Division!");

            double quota = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {quota}");
        } 
        
        private static void RunMultiplication( int num1, int num2)
        {
            Console.WriteLine("Multiplication!");

            int prod = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {prod}");

        }
        
        
      
    }
}
