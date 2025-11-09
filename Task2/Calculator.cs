namespace Task2;

public class Calculator(double a, double b, string operation)
{
    public double GetResult()
    {
        return operation switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b switch
            {
                0 => throw new DivideByZeroException(),
                _ => a / b
            },
            _ => throw new ArgumentException("Unknown operation")
        };
    }
}