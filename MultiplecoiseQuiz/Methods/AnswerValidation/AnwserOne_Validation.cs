namespace MultiplechoiseQuiz;

public class AnwserOne_Validation
{
    public static void AnwserOneValidation(int userNumber = 0)
    {
        userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 1)
        {
            Console.Clear();
            Console.WriteLine("Deine Antwort ist richtig, mach weiter so!\n");
        }

        if (userNumber != 1)
        {
            Console.Clear();
            Console.WriteLine("Deine Antowort ist leider Falsch.\n");
        }
    }  
}