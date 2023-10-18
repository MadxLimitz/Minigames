namespace MultiplechoiseQuiz;

public class AnwserTwo_Validation
{
    public static void AnwserTwoValidation(int userNumber = 0)
    {
        userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 2)
        {
            Console.Clear();
            Console.WriteLine("Deine Antwort ist richtig, mach weiter so!\n");
        }

        if (userNumber != 2)
        {
            Console.Clear();
            Console.WriteLine("Deine Antowort ist leider Falsch.\n");
        }
    }
}