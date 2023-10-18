namespace MainPage;

public class Description_Of_Games
{
    public void DescriptionOfGames()
    {
        Dividingline dividingline = new Dividingline();
        Navbar navbar = new Navbar();

        dividingline.Border();

        // Liste der Spiele
        Console.WriteLine("1. Multiplechoise Quiz\n");

        dividingline.Border();
        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.Clear();
                dividingline.Border();

                Console.WriteLine("Beim Multiplechoise Quiz wird dir eine Frage gestellt, du hast vier Antwortmöglichkeiten,\nwähle eine Antwort aus und sehe ob du richtig liegst.\n");
                
                dividingline.Border();
                navbar.Navigation();
                break;
        }
    }
}