using MainPage;
using System.Runtime.CompilerServices;

namespace MultiplechoiseQuiz;

public class Play_Query
{
    public static bool PlayQuery()
    {
        Main_Page main_Page = new Main_Page();
        Error_Message error_Message = new Error_Message();
        Dividingline dividingline = new Dividingline();

        Console.Clear();

        dividingline.Border();
        Console.WriteLine("Möchten Sie das Spiel spielen ? (Ja / Nein)\n");
        dividingline.Border();

        string? spielenJaNein = Console.ReadLine();

        if (spielenJaNein != null)
        {
            string lowercase = spielenJaNein.ToLower();

            if (lowercase == "ja")
                return true;

            if (lowercase == "nein")
            {
                Console.Clear();
                dividingline.Border();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Das Spiel wird beendet...\n");
                Console.ResetColor();

                dividingline.Border();
                Thread.Sleep(1500);
                Console.Clear();
                main_Page.MainPage();
            }
        }   
        return false;
    }
}