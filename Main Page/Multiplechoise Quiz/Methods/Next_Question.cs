using MainPage;

namespace MultiplechoiseQuiz;
public class Next_Question
{
    public void NextQuestion()
    {
        Dividingline dividingline = new Dividingline();

        Console.WriteLine("Für die Nächste Frage Enter drücken...\n");
        dividingline.Border();
        Console.ReadLine();
        Console.Clear();
    }
}