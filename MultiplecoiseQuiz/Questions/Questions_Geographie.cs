namespace MultiplechoiseQuiz;

public class Questions_Geographie
{
    public static void QuestionsGeographie(int userNumber = 0)
    {
        Console.WriteLine();
        Console.WriteLine("Welche der folgenden Institutionen ist in der Europäischen Union für die Gesetzgebung zuständig?");
        Console.WriteLine();
        Console.WriteLine("1. Europäischer Rat");
        Console.WriteLine("2. Europäisches Parlament");
        Console.WriteLine("3. Europäische Kommission");
        Console.WriteLine("4. Europäischer Gerichtshof");
        Console.WriteLine();

        AnwserTwo_Validation.AnwserTwoValidation();

        Next_Question nextQuestion = new Next_Question();
        nextQuestion.NextQuestion();

        Console.WriteLine();
        Console.WriteLine("Welches Land hat das größte Wahlkollegium bei der Wahl des Präsidenten?");
        Console.WriteLine();
        Console.WriteLine("1. Russland");
        Console.WriteLine("2. China");
        Console.WriteLine("3. USA");
        Console.WriteLine("4. Indien");
        Console.WriteLine();

        AnwserThree_Validation.AnwserThreeValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine();
        Console.WriteLine("Was ist ein Referendum in der Politik?");
        Console.WriteLine();
        Console.WriteLine("1. Eine Volksabstimmung über eine politische Frage");
        Console.WriteLine("2. Eine Wahl zum Bürgermeisteramt");
        Console.WriteLine("3. Eine Versammlung von Regierungsvertretern");
        Console.WriteLine("4. Ein geheimes Treffen von politischen Entscheidungsträgern");
        Console.WriteLine();

        AnwserOne_Validation.AnwserOneValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine();
        Console.WriteLine("Welche der folgenden Parteien ist in Deutschland für ihre liberale Ausrichtung bekannt?");
        Console.WriteLine();
        Console.WriteLine("1. CDU (Christlich Demokratische Union)");
        Console.WriteLine("2. SPD (Sozialdemokratische Partei Deutschlands)");
        Console.WriteLine("3. FDP (Freie Demokratische Partei)");
        Console.WriteLine("4. Die Linke");
        Console.WriteLine();

        AnwserThree_Validation.AnwserThreeValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine();
        Console.WriteLine("Was ist eine Monarchie ?");
        Console.WriteLine();
        Console.WriteLine("1. Eine Regierungsform, in der das Volk die höchste Autorität hat");
        Console.WriteLine("2. Eine Regierungsform, in der ein König oder eine Königin das Staatsoberhaupt ist");
        Console.WriteLine("3. Eine Regierungsform, in der die Macht von einer kleinen Gruppe ausgeübt wird");
        Console.WriteLine("4. Eine Regierungsform, in der die Armee das Land regiert");
        Console.WriteLine();

        AnwserTwo_Validation.AnwserTwoValidation();

        nextQuestion.NextQuestion();

        Console.WriteLine();
        Console.WriteLine("Welche der folgenden Länder ist eine parlamentarische Republik?");
        Console.WriteLine();
        Console.WriteLine("1. Frankreich");
        Console.WriteLine("2. Saudi-Arabien");
        Console.WriteLine("3. Nordkorea");
        Console.WriteLine("4. Ägypten");
        Console.WriteLine();

        AnwserOne_Validation.AnwserOneValidation();
        // Zurück ins Menü oder Neue Runde Spielen ?
    }
}