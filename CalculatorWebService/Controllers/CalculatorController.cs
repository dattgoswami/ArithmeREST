namespace CalculatorWebService.Controllers;
using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ISimpleCalculator _calculator;

    public CalculatorController(ISimpleCalculator calculator)
    {
        _calculator = calculator;
    }

    [HttpGet("add/{start}/{amount}")]
    public IActionResult Add(int start, int amount)
    {
        int result = _calculator.Add(start, amount);
        return Ok(result);
    }

    [HttpGet("subtract/{start}/{amount}")]
    public IActionResult Subtract(int start, int amount)
    {
        int result = _calculator.Subtract(start, amount);
        return Ok(result);
    }

    [HttpGet("multiply/{start}/{by}")]
    public IActionResult Multiply(int start, int by)
    {
        int result = _calculator.Multiply(start, by);
        return Ok(result);
    }

    [HttpGet("divide/{start}/{by}")]
    public IActionResult Divide(int start, int by)
    {
        try
        {
            int result = _calculator.Divide(start, by);
            return Ok(result);
        }
        catch (DivideByZeroException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}