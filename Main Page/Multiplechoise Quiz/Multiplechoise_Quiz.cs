using MainPage;

namespace MultiplechoiseQuiz;

public class Multiplechoise_Quiz
{
    public void MultiplechoiseQuiz()
    {
        Dividingline dividingline = new Dividingline();
        Main_Page main_Page = new Main_Page();
        Choose_Theme choose_Theme = new Choose_Theme();
        Play_Query spielen_Abfrage = new Play_Query();
        Loading_Main_Page_Message main_Page_Message = new Loading_Main_Page_Message();
        Error_Message error_Message = new Error_Message();
        Multiplechoise_Quiz multiplechoiseQuiz = new Multiplechoise_Quiz();

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
            error_Message.ErrorMessage();
            Thread.Sleep(1000);
            Console.Clear();
            multiplechoiseQuiz.MultiplechoiseQuiz();
        }
    }
}

// TODO - Wertung einbauen ob man das Modul geschafft hat
// Anzeigen bei welcher Frage man ist (3/10)