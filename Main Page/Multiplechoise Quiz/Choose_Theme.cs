﻿using MainPage;

namespace MultiplechoiseQuiz;

public class Choose_Theme
{
    public void ChooseTheme()
    {
        Questions_History questions_History = new Questions_History();
        Dividingline dividingline = new Dividingline();
        Navbar navbar = new Navbar();

        List<string> ChooseTheme = new List<string>();

        ChooseTheme.Add("Thema wählen:\n");
        ChooseTheme.Add("1. Geschichte");
        ChooseTheme.Add("2. <none>");
        ChooseTheme.Add("3. <none>\n");

        // Konsolen Ausgabe Anfang
        dividingline.Border();

        foreach (string theme in ChooseTheme)
        {
            Console.WriteLine(theme);
        }
        dividingline.Border();
        // Konsolen Ausgabe Ende

        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.Clear();
                questions_History.QuestionsHistory();
                break;

            case "2":
                Console.Clear();
                // TODO - Weitere Fragen einfügen
                dividingline.Border();

                Console.WriteLine("Weitere Themen sind in Arbeit... \n");

                dividingline.Border();
                Thread.Sleep(1500);
                break;

            case "3":
                Console.Clear();
                // TODO - Weitere Fragen einfügen
                dividingline.Border();

                Console.WriteLine("Weitere Themen sind in Arbeit... \n");

                dividingline.Border();
                Thread.Sleep(1500);
                break;
        }
    }
}

// TODO - Hauptmenü Option hinzufügen