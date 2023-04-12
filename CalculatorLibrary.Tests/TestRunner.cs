namespace CalculatorLibrary.Tests;

class TestRunner
{
    static void Main(string[] args)
    {
        SimpleCalculatorTests.TestAdd();
        SimpleCalculatorTests.TestSubtract();
        SimpleCalculatorTests.TestMultiply();
        SimpleCalculatorTests.TestDivide();

        Console.ReadLine();
    }
}