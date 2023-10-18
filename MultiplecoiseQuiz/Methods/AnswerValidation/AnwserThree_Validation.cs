namespace MultiplechoiseQuiz;

public class AnwserThree_Validation
{
    public static void AnwserThreeValidation(int userNumber = 0)
    {
        userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 3)
        {
            Console.Clear();
            Console.WriteLine("Deine Antwort ist richtig, mach weiter so!\n");
        }

        if (userNumber != 3)
        {
            Console.Clear();
            Console.WriteLine("Deine Antowort ist leider Falsch.\n");
        }
    }
}