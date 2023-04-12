namespace CalculatorTest;
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {

        // Initialize an HttpClient to send requests to the web service
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:5139/");

        // Add
        HttpResponseMessage response = await client.GetAsync("calculator/add/7/3");
        response.EnsureSuccessStatusCode();
        int result = await response.Content.ReadAsAsync<int>();
        Console.WriteLine("7 + 3 = " + result);

        // Subtract 
        response = await client.GetAsync("calculator/subtract/5/3");
        response.EnsureSuccessStatusCode();
        result = await response.Content.ReadAsAsync<int>();
        Console.WriteLine("5 - 3 = " + result);

        // Multiply
        response = await client.GetAsync("calculator/multiply/5/3");
        response.EnsureSuccessStatusCode();
        result = await response.Content.ReadAsAsync<int>();
        Console.WriteLine("5 * 3 = " + result);

        // Divide
        response = await client.GetAsync("calculator/divide/10/2");
        response.EnsureSuccessStatusCode();
        result = await response.Content.ReadAsAsync<int>();
        Console.WriteLine("10 / 2 = " + result);

        // Call the Divide method of the CalculatorController web service with a divisor of zero
        response = await client.GetAsync("calculator/divide/10/0");
        response.EnsureSuccessStatusCode();
        result = await response.Content.ReadAsAsync<int>();
        Console.WriteLine("10 / 2 = " + result);
    }
}