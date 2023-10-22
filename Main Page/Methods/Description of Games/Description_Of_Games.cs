namespace MainPage;

public class Description_Of_Games
{
    public void DescriptionOfGames()
    {
        Loading_Main_Page_Message main_Page_Message = new Loading_Main_Page_Message();
        Dividingline dividingline = new Dividingline();
        Navbar navbar = new Navbar();

        List<string> DescriptionOfGames = new List<string>();
        
        DescriptionOfGames.Add("1. Multiplechoise Quiz\n");
        DescriptionOfGames.Add("2. In Arbeit...\n");

        // Konsolen Ausgabe Anfang
        dividingline.Border();

        foreach (string description in DescriptionOfGames)
        {
            Console.WriteLine(description);
        }

        dividingline.Border();
        // Konsolen Ausgabe Ende

        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.Clear();
                dividingline.Border();

                Console.WriteLine("Beim Multiplechoise Quiz wird dir eine Frage gestellt, du hast vier Antwortmöglichkeiten,\nwähle eine Antwort aus und sehe ob du richtig liegst.\n");
                
                dividingline.Border();
                navbar.Navigation();
                main_Page_Message.LoadingMainPageMessage();
                break;

            case "2":
                Console.Clear();
                dividingline.Border();

                Console.WriteLine("Weitere Spiel sind in Arbeit...\n");

                dividingline.Border();
                navbar.Navigation();
                break;
        }
    }
}