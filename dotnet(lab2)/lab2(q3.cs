using System;

interface ICalculator
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    int Divide(int a, int b);
}

class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICalculator calculator = new Calculator();
        Console.WriteLine("Addition: " + calculator.Add(2, 3));
        Console.ReadLine();
        Console.WriteLine("Subtraction: " + calculator.Subtract(3,2));
        Console.ReadLine();
        Console.WriteLine("Multiplication: " + calculator.Multiply(2, 3));
        Console.ReadLine();
        Console.WriteLine("Division: " + calculator.Divide(20, 4));
        Console.ReadLine();
    }
}