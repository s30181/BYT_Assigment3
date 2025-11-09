using Task2;



Console.WriteLine($"3 + 4 = {new Calculator(3, 4, "+").GetResult()}");
Console.WriteLine($"5 - 8 = {new Calculator(5, 8, "-").GetResult()}");
Console.WriteLine($"4 * 9 = {new Calculator(4, 9, "*").GetResult()}");
Console.WriteLine($"27 / 3 = {new Calculator(27, 3, "/").GetResult()}");

var invalidCalculator = new Calculator(8, 0, "/");

try
{
    Console.WriteLine(invalidCalculator.GetResult());
}
catch (Exception e)
{
    Console.WriteLine("8 / 0 = ");
    Console.WriteLine(e);
}
