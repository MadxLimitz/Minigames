using MainPage;

namespace MultiplechoiseQuiz;

public class AnwserThree_Validation
{
    public static void AnwserThreeValidation(int userNumber = 0)
    {
        Dividingline dividingline = new Dividingline();

        userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 3)
        {
            Console.Clear();
            dividingline.Border();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Deine Antwort ist richtig, mach weiter so!\n");
            Console.ResetColor();
        }

        if (userNumber != 3)
        {
            Console.Clear();
            dividingline.Border();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Deine Antowort ist leider Falsch.\n");
            Console.ResetColor();
        }
    }
}