namespace CalculatorLibrary;

public interface IDiagnostics
{
    void Log(string message);
}
public class ConsoleDiagnostics : IDiagnostics
{
    public void Log(string message)
    {
        Console.WriteLine(message);

    }
}
public class DummyDiagnostics : IDiagnostics
{
    public void Log(string message)
    {
        // Do nothing
    }
}
public class SimpleCalculator : ISimpleCalculator
{
    private readonly IDiagnostics _diagnostics;

    public SimpleCalculator(IDiagnostics diagnostics)
    {
        _diagnostics = diagnostics ?? throw new ArgumentNullException(nameof(diagnostics));
    }

    public int Add(int start, int amount)
    {
        var result = checked(start + amount);
        _diagnostics.Log($"Add: {start} + {amount} = {result}");
        return result;
    }

    public int Subtract(int start, int amount)
    {
        var result = checked(start - amount);
        _diagnostics.Log($"Subtract: {start} - {amount} = {result}");
        return result;
    }

    public int Multiply(int start, int by)
    {
        var result = checked(start * by);
        _diagnostics.Log($"Multiply: {start} * {by} = {result}");
        return result;
    }

    public int Divide(int start, int by)
    {
        if (by == 0)
        {
            _diagnostics.Log($"Divide: {start} / {by} = Infinity");
            return int.MaxValue;
        }

        var result = start / by;
        _diagnostics.Log($"Divide: {start} / {by} = {result}");
        return result;
    }
}
