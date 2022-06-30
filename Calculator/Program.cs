// See https://aka.ms/new-console-template for more information
using Calculator.Helpers;
using Calculator.Service;

var a = 2.25;
var b = 3.25;
var sum = new CalculatorService();

Console.WriteLine($"Sum : {sum.Add(a, b)}");
var selfList = new List<CalculatorService>();
//Console.WriteLine($"From Helper Sum : {CalculatorHelper.Add(2, 3)}");
//Console.WriteLine($"From Extension Sum : {2.Add(3).Add(5).Add(3)}");