using MainPage;

namespace MultiplechoiseQuiz;

public class Questions_Geographie
{
    public static void QuestionsGeographie(int userNumber = 0)
    {
        Dividingline dividingline = new Dividingline();

        dividingline.Border();
        Console.WriteLine("Welche der folgenden Institutionen ist in der Europäischen Union für die Gesetzgebung zuständig?\n");

        Console.WriteLine("1. Europäischer Rat");
        Console.WriteLine("2. Europäisches Parlament");
        Console.WriteLine("3. Europäische Kommission");
        Console.WriteLine("4. Europäischer Gerichtshof\n");
        dividingline.Border();

        AnwserTwo_Validation.AnwserTwoValidation();

        Next_Question nextQuestion = new Next_Question();
        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Welches Land hat das größte Wahlkollegium bei der Wahl des Präsidenten?\n");

        Console.WriteLine("1. Russland");
        Console.WriteLine("2. China");
        Console.WriteLine("3. USA");
        Console.WriteLine("4. Indien\n");
        dividingline.Border();

        AnwserThree_Validation.AnwserThreeValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Was ist ein Referendum in der Politik?\n");

        Console.WriteLine("1. Eine Volksabstimmung über eine politische Frage");
        Console.WriteLine("2. Eine Wahl zum Bürgermeisteramt");
        Console.WriteLine("3. Eine Versammlung von Regierungsvertretern");
        Console.WriteLine("4. Ein geheimes Treffen von politischen Entscheidungsträgern\n");
        dividingline.Border();

        AnwserOne_Validation.AnwserOneValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Welche der folgenden Parteien ist in Deutschland für ihre liberale Ausrichtung bekannt?\n");

        Console.WriteLine("1. CDU (Christlich Demokratische Union)");
        Console.WriteLine("2. SPD (Sozialdemokratische Partei Deutschlands)");
        Console.WriteLine("3. FDP (Freie Demokratische Partei)");
        Console.WriteLine("4. Die Linke\n");
        dividingline.Border();

        AnwserThree_Validation.AnwserThreeValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Was ist eine Monarchie ?\n");

        Console.WriteLine("1. Eine Regierungsform, in der das Volk die höchste Autorität hat");
        Console.WriteLine("2. Eine Regierungsform, in der ein König oder eine Königin das Staatsoberhaupt ist");
        Console.WriteLine("3. Eine Regierungsform, in der die Macht von einer kleinen Gruppe ausgeübt wird");
        Console.WriteLine("4. Eine Regierungsform, in der die Armee das Land regiert\n");
        dividingline.Border();

        AnwserTwo_Validation.AnwserTwoValidation();

        nextQuestion.NextQuestion();

        dividingline.Border();
        Console.WriteLine("Welche der folgenden Länder ist eine parlamentarische Republik?\n");

        Console.WriteLine("1. Frankreich");
        Console.WriteLine("2. Saudi-Arabien");
        Console.WriteLine("3. Nordkorea");
        Console.WriteLine("4. Ägypten\n");
        dividingline.Border();

        AnwserOne_Validation.AnwserOneValidation();
        // TODO - Nach der Letzten Frage anzeigen ob antwort richtig oder Falsch
        // TODO - Zurück ins Menü oder Neue Runde Spielen ?
    }
}