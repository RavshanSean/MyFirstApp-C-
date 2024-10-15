using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator!");

            while (true)
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation: +, -, *, /");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation? (y/n): ");
                char continueCalc = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (continueCalc != 'y' && continueCalc != 'Y')
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using the calculator! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
