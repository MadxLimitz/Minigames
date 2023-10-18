using MainPage;

namespace MultiplechoiseQuiz;

public class Questions_History
{
    public static void QuestionsHistory(int userNumber = 0)
    {
        Dividingline dividingline = new Dividingline();

        dividingline.Border();

        Console.WriteLine("Wann begann der Erste Weltkrieg ?\n");

        Console.WriteLine("1. 1914");
        Console.WriteLine("2. 1918");
        Console.WriteLine("3. 1938");
        Console.WriteLine("4. 1945\n");
        dividingline.Border();

        AnwserOne_Validation.AnwserOneValidation();

        Next_Question nextQuestion = new Next_Question();
        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Wer war der erste Präsident der Vereinigten Staaten ?\n");

        Console.WriteLine("1. John Adams");
        Console.WriteLine("2. George Washington");
        Console.WriteLine("3. Thomas Jefferson");
        Console.WriteLine("4. Benjamin Franklin\n");
        dividingline.Border();

        AnwserTwo_Validation.AnwserTwoValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Welches Ereignis markierte das Ende des Kalten Krieges ?\n");

        Console.WriteLine("1. Die Kubakrise");
        Console.WriteLine("2. Die Invasion in der Schweinebucht");
        Console.WriteLine("3. Der Fall der Berliner Mauer");
        Console.WriteLine("4. Die Gründung der NATO\n");
        dividingline.Border();

        AnwserThree_Validation.AnwserThreeValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Wann fand die Französische Revolution statt ?\n");

        Console.WriteLine("1. 1789 - 1799");
        Console.WriteLine("2. 1812 - 1814");
        Console.WriteLine("3. 1905 - 1911");
        Console.WriteLine("4. 1666 - 1668\n");
        dividingline.Border();

        AnwserOne_Validation.AnwserOneValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Wer war der Architekt der Berliner Mauer ?\n");

        Console.WriteLine("1. Nikita Chruschtschow");
        Console.WriteLine("2. Leonid Breschnew");
        Console.WriteLine("3. Erich Honecker");
        Console.WriteLine("4. Walter Ulbricht\n");
        dividingline.Border();

        AnwserFour_Validation.AnwserFourValidation();
        // TODO - Nach der Letzten Frage anzeigen ob antwort richtig oder Falsch
        // TODO - Zurück ins Menü oder Neue Runde Spielen ?

    }
}