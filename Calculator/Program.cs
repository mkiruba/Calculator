// See https://aka.ms/new-console-template for more information
using Calculator.Service;

var a = 2;
var b = 3;
var sum = new CalculatorService();

Console.WriteLine($"Sum : {sum.Add(2, 3)}");
