namespace MultiplechoiseQuiz;

public class Questions_History
{
    public static void QuestionsHistory(int userNumber = 0)
    {
        Console.WriteLine();
        Console.WriteLine("Wann begann der Erste Weltkrieg ?");
        Console.WriteLine();
        Console.WriteLine("1. 1914");
        Console.WriteLine("2. 1918");
        Console.WriteLine("3. 1938");
        Console.WriteLine("4. 1945");
        Console.WriteLine();

        AnwserOne_Validation.AnwserOneValidation();

        Next_Question nextQuestion = new Next_Question();
        nextQuestion.NextQuestion();

        Console.WriteLine();
        Console.WriteLine("Wer war der erste Präsident der Vereinigten Staaten ?");
        Console.WriteLine();
        Console.WriteLine("1. John Adams");
        Console.WriteLine("2. George Washington");
        Console.WriteLine("3. Thomas Jefferson");
        Console.WriteLine("4. Benjamin Franklin");
        Console.WriteLine();

        AnwserTwo_Validation.AnwserTwoValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine();
        Console.WriteLine("Welches Ereignis markierte das Ende des Kalten Krieges ?");
        Console.WriteLine();
        Console.WriteLine("1. Die Kubakrise");
        Console.WriteLine("2. Die Invasion in der Schweinebucht");
        Console.WriteLine("3. Der Fall der Berliner Mauer");
        Console.WriteLine("4. Die Gründung der NATO");
        Console.WriteLine();

        AnwserThree_Validation.AnwserThreeValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine();
        Console.WriteLine("Wann fand die Französische Revolution statt ?");
        Console.WriteLine();
        Console.WriteLine("1. 1789 - 1799");
        Console.WriteLine("2. 1812 - 1814");
        Console.WriteLine("3. 1905 - 1911");
        Console.WriteLine("4. 1666 - 1668");
        Console.WriteLine();

        AnwserOne_Validation.AnwserOneValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine();
        Console.WriteLine("Wer war der Architekt der Berliner Mauer ?");
        Console.WriteLine();
        Console.WriteLine("1. Nikita Chruschtschow");
        Console.WriteLine("2. Leonid Breschnew");
        Console.WriteLine("3. Erich Honecker");
        Console.WriteLine("4. Walter Ulbricht");
        Console.WriteLine();

        AnwserFour_Validation.AnwserFourValidation();
        // Zurück ins Menü oder Neue Runde Spielen ?

    }
}