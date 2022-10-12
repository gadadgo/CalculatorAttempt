

using System.Transactions;

var introduction = "Calculator app. Enter the first number";

Console.WriteLine($"{introduction}");

var input1 = Console.ReadLine();
Console.WriteLine("Enter the second number");
var input2 = Console.ReadLine();


var result = (int.Parse(input1)) + (int.Parse(input2));
Console.WriteLine($"{result}");