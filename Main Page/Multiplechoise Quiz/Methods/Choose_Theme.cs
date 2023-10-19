using MainPage;

namespace MultiplechoiseQuiz;

public class Choose_Theme
{
    public void ChooseTheme()
    {
        Questions_History questions_History = new Questions_History();
        Dividingline dividingline = new Dividingline();

        dividingline.Border();
        // TODO - Liste erstellen ↓↓↓
        Console.WriteLine("Thema wählen:\n");
        Console.WriteLine("1. Geschichte");
        Console.WriteLine("2. <none>");
        Console.WriteLine("3. <none>\n");
        dividingline.Border();

        int userInput = Convert.ToInt32(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                Console.Clear();
                questions_History.QuestionsHistory();
                break;

            case 2:
                Console.Clear();
                // Fragen einfügen
                break;

            case 3:
                Console.Clear();
                // Fragen einfügen
                break;
        }
    }
}