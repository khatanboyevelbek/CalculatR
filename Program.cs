namespace CalculatR.Classes 
{
    public class CalculatR 
    {
        public static void Main(string[] args)
        {
            try 
            {
                decimal? valueOfOperation = Calculating();
                Console.WriteLine(format: "Result: {0}", arg0: valueOfOperation);
            } catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        public static decimal? Calculating()
        {
            Console.Write("Enter first number: ");
            int? firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int? secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter arithmetic operation: ");
            string? operation = Console.ReadLine();
            decimal? result = operation switch {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "/" => firstNumber / secondNumber,
                "*" => firstNumber * secondNumber,
                _ => throw new Exception(message: "Operation failed")
            };
            return result;
        }
    }
}