using MainPage;

namespace MultiplechoiseQuiz;
public class Multiplechoise_Quiz
{
    public static void MultiplechoiseQuiz()
    {
        Dividingline dividingline = new Dividingline();
        Main_Page main_Page = new Main_Page();
        Choose_Theme choose_Theme = new Choose_Theme();
        Play_Query spielen_Abfrage = new Play_Query();

        if (Play_Query.PlayQuery())
        {
            do
            {
                Console.Clear();
                choose_Theme.ChooseTheme();
            } while (true);
        }
        else
        {
            Console.Clear();

            dividingline.Border();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hauptseite wird geladen...\n");
            Console.ResetColor();
            dividingline.Border();

            Thread.Sleep(1500);
            Console.Clear();

            main_Page.MainPage();
        }
    }
}

// TODO - Wertung einbauen ob man das Modul geschafft hat