namespace MultiplechoiseQuiz;

public class Choose_Theme
{
    public void ChooseTheme()
    {
        Console.WriteLine();
        Console.WriteLine("Thema wählen:");
        Console.WriteLine();
        Console.WriteLine("1. Österreich");
        Console.WriteLine("2. Geografie");
        Console.WriteLine("3. Geschichte\n");

        int userInput = Convert.ToInt32(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                Console.Clear();
                Questions_Austria.QuestionsAustria();
                break;

            case 2:
                Console.Clear();
                Questions_Geographie.QuestionsGeographie();
                break;

            case 3:
                Console.Clear();
                Questions_History.QuestionsHistory();
                break;
        }
    }
}