using MultiplechoiseQuiz;

namespace MainPage;

public class Game_List
{
    public void GameList()
    {
        Multiplechoise_Quiz multiplechoise_Quiz = new Multiplechoise_Quiz();
        Dividingline dividingline = new Dividingline();

        List<string> GameList = new List<string>();

        GameList.Add("1. Multiplechoise Quiz\n");
        GameList.Add("2. In Arbeit...\n");


        // Konsolen Ausgabe Anfang
        dividingline.Border();

        foreach (string game in GameList)
        {
            Console.WriteLine(game);
        }

        dividingline.Border();
        // Konsolen Ausgabe Anfang

        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Multiplechoise_Quiz.MultiplechoiseQuiz();
                break;

            case "2":
                Console.Clear();
                dividingline.Border();

                Console.WriteLine("Weitere spiele sind in Arbeit...\n");

                dividingline.Border();
                Thread.Sleep(1500);
                Console.Clear();
                break;
        }
    }
}