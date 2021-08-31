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

                Console.Write("Enter a calculation method: +, -, / or * (or -1 to exit): ");
                char calculationChoice = char.Parse(Console.ReadLine());
                try
                {
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
                        case '#':
                            keepCalculating = false;
                            break;
                    }
                }
                catch
                {

                }

            }
        }//end main

        private static void RunSubtraction()
        {
            Console.WriteLine("Subtraction!");
        } 
        private static void RunAddition()
        {
            Console.WriteLine("Addition!");
        } 
        private static void RunDivision()
        {
            Console.WriteLine("Division!");
        } 
        
        private static void RunMultiplication()
        {
            Console.WriteLine("Multiplication!");
        }
    }
}
