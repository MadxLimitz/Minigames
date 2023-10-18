namespace MainPage;

public class Navbar
{
    public void Navigation()
    {
        Error_Message error_Message = new Error_Message();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Um in das Hauptmenü zu kommen drücken Sie \"M\"");
        Console.ResetColor();

        string? userInput = Console.ReadLine();

        if (userInput != null)
        {
            userInput = userInput.ToLower();

            if (userInput == "m")
            {
                Main_Page main_page = new Main_Page();

                Console.Clear();
                main_page.MainPage();
            }
            else
            {
                error_Message.ErrorMessage();
            }
        }
        else
        {
            error_Message.ErrorMessage();
        }
    }
}