using CalculatR.Classes;

namespace CalculatR.App;
public class CalculatR
{
    public static void Main(string[] args)
    {
        try
        {
            Security security = new();
            Calculator calculatr = new();
            security.CheckPassword();
            calculatr.GetInputs();
            calculatr.AboutValues();
            calculatr.Calculating();
            calculatr.MultiplicationTable(out int number);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
    
}