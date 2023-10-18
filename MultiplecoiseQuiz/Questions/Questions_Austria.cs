namespace MultiplechoiseQuiz;
public class Questions_Austria
{
    public static void QuestionsAustria(int userNumber = 0)
    {
        Console.WriteLine();
        Console.WriteLine("Welcher der folgenden Flüsse durchfließt Österreich?");
        Console.WriteLine();
        Console.WriteLine("1. Rhein");
        Console.WriteLine("2. Donau");
        Console.WriteLine("3. Seine");
        Console.WriteLine("4. Themse");
        Console.WriteLine();

        AnwserTwo_Validation.AnwserTwoValidation();

        Next_Question nextQuestion = new Next_Question();
        nextQuestion.NextQuestion();

        Console.WriteLine("Welches Gebirge erstreckt sich durch den Westen von Österreich?");
        Console.WriteLine();
        Console.WriteLine("1. Karpaten");
        Console.WriteLine("2. Alpen");
        Console.WriteLine("3. Pyrenäen");
        Console.WriteLine("4. Apenninen");
        Console.WriteLine();

        AnwserTwo_Validation.AnwserTwoValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine("Welcher österreichische Komponist ist besonders bekannt für seine Walzer und Operetten?");
        Console.WriteLine();
        Console.WriteLine("1. Franz Schubert");
        Console.WriteLine("2. Ludwig van Beethoven");
        Console.WriteLine("3. Wolfgang Amadeus Mozart");
        Console.WriteLine("4. Johann Strauss II");
        Console.WriteLine();

        AnwserFour_Validation.AnwserFourValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine("Welche politische Funktion hat der Bundespräsident in Österreich?");
        Console.WriteLine();
        Console.WriteLine("1. Regierungschef");
        Console.WriteLine("2. Staatsoberhaupt");
        Console.WriteLine("3. Parlamentspräsident");
        Console.WriteLine("4. Bürgermeister von Wien");
        Console.WriteLine();

        AnwserTwo_Validation.AnwserTwoValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine("Was wurde 1955 im Schloss Belvedere Unterschrieben ?");
        Console.WriteLine();
        Console.WriteLine("1. UN-Mitgliedschaft");
        Console.WriteLine("2. NATO-Beitritt");
        Console.WriteLine("3. Neutralitätsgesetz");
        Console.WriteLine("4. Österreichischer Staatsvertrag");
        Console.WriteLine();

        AnwserFour_Validation.AnwserFourValidation();
        // Zurück ins Menü oder Neue Runde Spielen ?
    }
}
