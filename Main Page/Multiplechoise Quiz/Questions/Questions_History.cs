namespace MultiplechoiseQuiz;

public class Questions_History
{
    public void QuestionsHistory()
    {
        List<IQuestion> questions = new List<IQuestion>
        {
            new Class_QuestionsHistory("Wann begann der Zweite Weltkrieg?\n",
                new List<string>{"1. 1936", "2. 1939", "3. 1942", "4. 1945"}, "2"),

            new Class_QuestionsHistory("Welches Land griff Polen an und löste damit den Zweiten Weltkrieg aus?\n",
                new List<string>{"1. Deutschland", "2. Japan", "3. Italien", "4. Sovjetunion"}, "1"),
            
            new Class_QuestionsHistory("Welches Ereignis führte zur Beteiligung der USA am Zweiten Weltkrieg?\n",
                new List<string>{ "1. Angriff auf Pearl Harbor", "2. Schlacht um Stalingrad", "3. D-Day", "4. Bombardierung von London"}, "1"),

            new Class_QuestionsHistory("Welche Länder bildeten die Alliierten im Zweiten Weltkrieg?\n",
                new List<string>{ "1. Deutschland, Japan, Italien", "2. USA, Großbritannien, Sowjetunion", "3. Deutschland, Frankreich, Italien", "4. Japan, Sowjetunion, China\n"}, "2"),

            new Class_QuestionsHistory("Wann endete der Zweite Weltkrieg in Europa\n?",
                new List<string>{"1. 1943", "2. 1945", "3. 1947", "4. 1950"}, "2"),

            new Class_QuestionsHistory("Was war die Operation Overlord\n?",
                new List<string>{ "1. Die Landung der Alliierten in der Normandie", "2. Die Bombardierung von London", "3. Die Schlacht um Stalingrad", "4. Der Angriff auf Pearl Harbor\n"}, "1"),

            new Class_QuestionsHistory("Welche Stadt war das Ziel der ersten Atombombe im Zweiten Weltkrieg?\n",
                new List<string>{ "1. Tokio", "2. Berlin", "3. Hiroshima", "4. Rom"}, "3"),

            new Class_QuestionsHistory("Welches Land kapitulierte zuerst im Zweiten Weltkrieg?\n",
                new List<string>{"1. Deutschland", "2. Japan", "3. Italien", "4. Sovjetunion"}, "3"),

            new Class_QuestionsHistory("Wer war der Führer der Sowjetunion während des Zweiten Weltkriegs?\n",
                new List<string>{ "1. Joseph Stalin", "2. Vladimir Lenin", "3. Nikita Chruschtschow", "4. Mikhail Gorbatschow"}, "1"),

            new Class_QuestionsHistory("Welche Konferenz führte zur Teilung Deutschlands nach dem Zweiten Weltkrieg?\n",
                new List<string>{ "1. Yalta-Konferenz", "2. Teheran-Konferenz", "3. Jalta-Konferenz", "4. Potsdamer Konferenz"}, "4"),
        };

        // TODO - Jede frage einzeln ausgeben mit den Bordern antwort möglichkeit abfangen und dann die nächste frage generieren (wie bei den alten fragen)
        Random randomGenerator = new Random();

        questions = questions.OrderBy(frage => randomGenerator.Next()).ToList();

        foreach (var question in questions)
        {
            Console.WriteLine(question.Question);

            foreach (var option in question.AwnserOptions)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine();
        }
    }
}