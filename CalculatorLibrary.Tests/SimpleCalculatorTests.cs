namespace CalculatorLibrary.Tests;
using System;
using CalculatorLibrary;

public class SimpleCalculatorTests
{
    public static void TestAdd()
    {
        var calculator = new SimpleCalculator(new ConsoleDiagnostics());
        int result = calculator.Add(3, 4);
        if (result != 7)
        {
            Console.WriteLine("TestAdd failed: Expected 7 but got " + result);
        }
        else
        {
            Console.WriteLine("TestAdd passed");
        }
    }

    public static void TestSubtract()
    {
        var calculator = new SimpleCalculator(new ConsoleDiagnostics());
        int result = calculator.Subtract(8, 3);
        if (result != 5)
        {
            Console.WriteLine("TestSubtract failed: Expected 5 but got " + result);
        }
        else
        {
            Console.WriteLine("TestSubtract passed");
        }
    }

    public static void TestMultiply()
    {
        var calculator = new SimpleCalculator(new ConsoleDiagnostics());
        int result = calculator.Multiply(2, 3);
        if (result != 6)
        {
            Console.WriteLine("TestMultiply failed: Expected 6 but got " + result);
        }
        else
        {
            Console.WriteLine("TestMultiply passed");
        }
    }

    public static void TestDivide()
    {
        var calculator = new SimpleCalculator(new ConsoleDiagnostics());
        int result = calculator.Divide(6, 3);
        if (result != 2)
        {
            Console.WriteLine("TestDivide failed: Expected 2 but got " + result);
        }
        else
        {
            Console.WriteLine("TestDivide passed");
        }
    }
}


