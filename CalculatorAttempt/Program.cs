

using System.Transactions;

Console.WriteLine($"Calculator app. Enter the first number");
double input1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the next number");
double input2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($@"Choose the operation
A - Add
S - Subtract
M - Multiply
D - Divide");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result {input1} + {input2} = " + (input1 + input2));
        break;
    case "s":
        Console.WriteLine($"Your result {input1} - {input2} = " + (input1 - input2));
        break;
    case "m":
        Console.WriteLine($"Your result {input1} * {input2} = " + (input1 * input2));
        break;
    case "d":
        while (input2 == 0){
            Console.WriteLine("Enter a non 0 value");
            input2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Your result {input1} / {input2} = " + (input1 / input2));
        break;
} 





