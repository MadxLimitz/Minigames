namespace MultiplechoiseQuiz;

public class AnwserFour_Validation
{
    public static void AnwserFourValidation(int userNumber = 0)
    {
        userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 4)
        {
            Console.Clear();
            Console.WriteLine("Deine Antwort ist richtig, mach weiter so!\n");
        }

        if (userNumber != 4)
        {
            Console.Clear();
            Console.WriteLine("Deine Antowort ist leider Falsch.\n");
        }
    }
}