using MainPage;

namespace MultiplechoiseQuiz;

public class AnwserOne_Validation
{
    public static void AnwserOneValidation(int userNumber = 0)
    {
        Dividingline dividingline = new Dividingline();

        userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 1)
        {
            Console.Clear();
            dividingline.Border();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Deine Antwort ist richtig, mach weiter so!\n");
            Console.ResetColor();
        }

        if (userNumber != 1)
        {
            Console.Clear();
            dividingline.Border();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Deine Antowort ist leider Falsch.\n");
            Console.ResetColor();
        }
    }  
}