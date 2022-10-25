namespace CalculatR.Classes;
public class Security
{
    private static string password = "elbek2001";
    public void CheckPassword()
    {
        string enteredPassword;
        do
        {
            Console.Write("Enter your Password: ");
            enteredPassword = Console.ReadLine();
        } while(enteredPassword != password);
    }
}