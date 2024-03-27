using System;

class A
{
    public void Display()
    {
        Console.WriteLine("Class A");
        Console.ReadLine();
    }
}

class B : A
{
    public void Show()
    {
        Console.WriteLine("Class B");
        Console.ReadLine();
    }
}

class C : B
{
    public void Print()
    {
        Console.WriteLine("Class C");
        Console.ReadLine();
    }
}

class D
{
    public void Show()
    {
        Console.WriteLine("Class D");
        Console.ReadLine();
    }
}

class E : D
{
    public void Print()
    {
        Console.WriteLine("Class E");
        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        C objC = new C();
        objC.Display();
        objC.Show();
        objC.Print();

        E objE = new E();
        objE.Show();
        objE.Print();
    }
}
