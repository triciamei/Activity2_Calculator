using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello from feature branch!");

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
            result = num1 / num2;
        else
            Console.WriteLine("Invalid operator");

        Console.WriteLine("Result: " + result);
    }
}