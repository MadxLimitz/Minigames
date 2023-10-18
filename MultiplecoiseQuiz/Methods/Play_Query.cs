namespace MultiplechoiseQuiz;

public class Play_Query
{
    public static bool PlayQuery()
    {
        Console.WriteLine("Möchten Sie das Spiel spielen ? (Ja / Nein)");
        #pragma warning disable CS8600
        string spielenJaNein = Console.ReadLine(); 
        #pragma warning restore CS8600

        if (spielenJaNein != null)
        {
            string lowercase = spielenJaNein.ToLower();

            if (lowercase == "ja")
                return true;

            if (lowercase != "nein" || lowercase != "ja")
                Console.Clear();
                Console.WriteLine("Falsche Eingabe, das Programm wird beendet");
        }
        return false;
    }
}