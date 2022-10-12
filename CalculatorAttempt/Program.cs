

using System.Transactions;

Console.WriteLine($"Calculator app. Enter the first number");
var input1 = Console.ReadLine();

Console.WriteLine($@"Choose the operation
A - Add
S - Subtract
M - Multiply
D - Divide");

var operation = Console.ReadLine();

Console.WriteLine("Enter the next number");
var input2 = Console.ReadLine();


