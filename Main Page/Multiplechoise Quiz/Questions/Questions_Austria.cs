using MainPage;

namespace MultiplechoiseQuiz;
public class Questions_Austria
{
    public static void QuestionsAustria(int userNumber = 0)
    {
        Dividingline dividingline = new Dividingline();

        dividingline.Border();
        Console.WriteLine("Welcher der folgenden Flüsse durchfließt Österreich?\n");

        Console.WriteLine("1. Rhein");
        Console.WriteLine("2. Donau");
        Console.WriteLine("3. Seine");
        Console.WriteLine("4. Themse\n");
        dividingline.Border();

        AnwserTwo_Validation.AnwserTwoValidation();

        Next_Question nextQuestion = new Next_Question();
        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Welches Gebirge erstreckt sich durch den Westen von Österreich?\n");

        Console.WriteLine("1. Karpaten");
        Console.WriteLine("2. Alpen");
        Console.WriteLine("3. Pyrenäen");
        Console.WriteLine("4. Apenninen\n");
        dividingline.Border();

        AnwserTwo_Validation.AnwserTwoValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Welcher österreichische Komponist ist besonders bekannt für seine Walzer und Operetten?\n");

        Console.WriteLine("1. Franz Schubert");
        Console.WriteLine("2. Ludwig van Beethoven");
        Console.WriteLine("3. Wolfgang Amadeus Mozart");
        Console.WriteLine("4. Johann Strauss II\n");
        dividingline.Border();


        AnwserFour_Validation.AnwserFourValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Welche politische Funktion hat der Bundespräsident in Österreich?\n");

        Console.WriteLine("1. Regierungschef");
        Console.WriteLine("2. Staatsoberhaupt");
        Console.WriteLine("3. Parlamentspräsident");
        Console.WriteLine("4. Bürgermeister von Wien\n");
        dividingline.Border();

        AnwserTwo_Validation.AnwserTwoValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Was wurde 1955 im Schloss Belvedere Unterschrieben ?\n");

        Console.WriteLine("1. UN-Mitgliedschaft");
        Console.WriteLine("2. NATO-Beitritt");
        Console.WriteLine("3. Neutralitätsgesetz");
        Console.WriteLine("4. Österreichischer Staatsvertrag\n");
        dividingline.Border();

        AnwserFour_Validation.AnwserFourValidation();
        // TODO - Nach der Letzten Frage anzeigen ob antwort richtig oder Falsch
        // TODO - Zurück ins Menü oder Neue Runde Spielen ?
    }
}
