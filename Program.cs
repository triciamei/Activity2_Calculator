using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0;

            if (op == '+')
                result = num1 + num2;
            else if (op == '-')
                result = num1 - num2;
            else if (op == '*')
                result = num1 * num2;
            else if (op == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    continue;
                }
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid operator");
                continue;
            }

            Console.WriteLine("Result: " + result);

            Console.Write("Try again? (y/n): ");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice != 'y')
                break;
        }
    }
}