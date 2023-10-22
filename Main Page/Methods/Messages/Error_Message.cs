namespace MainPage;

public class Error_Message
{
    public void ErrorMessage()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Falsche Eingabe");
        Console.ResetColor();
    }
}