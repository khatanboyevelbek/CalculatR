namespace CalculatR.Classes;
public class Calculator
{
    public static decimal FirstNumber { get; set; }
    public static decimal SecondNumber { get; set; }
    public void GetInputs()
    {
        Console.Write("Enter first number: ");
        FirstNumber = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter second number: ");
        SecondNumber = Convert.ToDecimal(Console.ReadLine());
    }
    public void AboutValues()
    {
        string informationOfNumbers = FirstNumber >= 0 && SecondNumber >= 0
            ? "Both of the numbers are positive"
            : FirstNumber >= 0 || SecondNumber >= 0
            ? "One of the numbers is positive"
            : "Both of the numbers are negative";
        Console.WriteLine($"Information about above numbers: {informationOfNumbers}");
    }
    public void Calculating()
    {
        Console.Write("Enter arithmetic operation: ");
        string? operation = Console.ReadLine();
        decimal result = operation switch
        {
            "+" => FirstNumber + SecondNumber,
            "-" => FirstNumber - SecondNumber,
            "/" => FirstNumber / SecondNumber,
            "*" => FirstNumber * SecondNumber,
            _ => throw new Exception(message: "Operation failed")
        };
        Console.WriteLine(format: "Result: {0}", arg0: Math.Round(result,2));
    }
    public void MultiplicationTable(out int number)
    {
        Console.Write("Enter number from 1 to 9 to explore the times table: ");
        number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine("");
        }
    }
}