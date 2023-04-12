# Simple Calculator REST API 

This is a simple calculator that provides a REST API written in C# using MVC architecture to perform basic arithmetic operations.
The project includes a library for performing calculations, a test library, and a web service project for exposing the calculator via HTTP.

## Modules 
-CalculatorLibrary
The CalculatorLibrary project contains the ISimpleCalculator and SimpleCalculator classes.
The ISimpleCalculator interface defines the basic arithmetic operations that the calculator can perform.
The SimpleCalculator class implements the interface and provides the actual arithmetic functionality.

-CalculatorLibrary.Tests
The CalculatorLibrary.Tests project contains the SimpleCalculatorTests and TestRunner classes.
The SimpleCalculatorTests class contains unit tests for the SimpleCalculator class.
The TestRunner class has the stub which calls the tests.

-CalculatorTest
The CalculatorTest project contains the Program.cs file, which creates the HttpClient and registers the url
for using the calculator via the CalculatorController. 

-CalculatorWebService
The CalculatorWebService project contains the CalculatorController class, which provides the REST API endpoints for the calculator.
The Program.cs file creates and configures the web application.

## Usage
To use the calculator, clean and build the CalculatorTest application.
If you want to run the tests then run CalculatorLibrary.Tests.
To get the API server running you need to run CalculatorWebService.
Once that is running, run the CalculatorTest.

CalculatorTest makes calls the CalculatorWebService which has the controller which calls the SimpleCalculator from the CalculatorLibrary.

Example URL [GET]: https://localhost:port/calculator/add/8/8

Dependencies
The project requires .NET 7.0.202 or later and the following NuGet packages:
Microsoft.NETCore.App

-CalculatorWebService
Microsoft.AspNetCore.OpenApi
Swashbuckle.AspNetCore

-CalculatorTest
Microsoft.AspNet.WebApi.Client