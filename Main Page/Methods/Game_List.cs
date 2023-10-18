using MultiplechoiseQuiz;

namespace MainPage;

public class Game_List
{
    public void GameList()
    {
        Multiplechoise_Quiz multiplechoise_Quiz = new Multiplechoise_Quiz();
        Dividingline dividingline = new Dividingline();

        dividingline.Border();

        Console.WriteLine("1. Multiplechoise Quiz\n");
        Console.WriteLine("2. In Arbeit...\n");

        dividingline.Border();

        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Multiplechoise_Quiz.MultiplechoiseQuiz();
                break;

            case "2":
                Console.WriteLine("In Arbeit\n");
                break;
        }
    }
}