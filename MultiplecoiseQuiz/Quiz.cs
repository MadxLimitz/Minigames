namespace MultiplechoiseQuiz;

// Done

public class Multiplechoise_Quiz
{
    public void MultiplechoiseQuiz()
    {
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
            // TODO - Zur Hauptseite anstatt Programm beenden!
            Environment.Exit(0);
        }
    }
}

// TODO - Wertung einbauen ob man das Modul geschafft hat
// TODO - Clear nach jeder Frage einbauen !