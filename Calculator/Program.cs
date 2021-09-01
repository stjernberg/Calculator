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
                        case 'e':
                            keepCalculating = false;
                            break;
                        default:
                            Console.WriteLine("That is not a valid option");
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("That is not a valid option");
                }

            }
        }//end main

        private static void RunSubtraction()
        {
            Console.WriteLine("Subtraction!");
           
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("-");
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse (Console.ReadLine());
            int difference = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {difference}");

        } 
        private static void RunAddition()
        {
            Console.WriteLine("Addition!");

            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("+");
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");
        } 
        private static void RunDivision() 
        {
            Console.WriteLine("Division!");

            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("/");
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int quota = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {quota}");
        } 
        
        private static void RunMultiplication()
        {
            Console.WriteLine("Multiplication!");

            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("*");
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int product = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {product}");

        }

      
    }
}
