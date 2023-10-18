﻿namespace MainPage;
using MultiplechoiseQuiz;
public class Main_Page
{
    public void MainPage()
    {
        Game_List game_List = new Game_List();
        Creator_Information get_creator_information = new Creator_Information();
        Description_Of_Games get_description_of_games = new Description_Of_Games();
        Dividingline dividingline = new Dividingline();

        dividingline.Border();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Hauptseite\n");
        Console.ResetColor();

        Console.WriteLine("1. Spiele\n");
        Console.WriteLine("2. Beschreibung der Spiele\n");
        Console.WriteLine("3. Ersteller\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Geben Sie die Nummern ein und Drücken Sie die \"Enter-Taste\" zum Auswählen!\n");
        Console.ResetColor();

        dividingline.Border();

        string? userInput = Console.ReadLine();
        Console.Clear();

        if (userInput != null)
        {
            switch (userInput)
            {
                case "1":
                    game_List.GameList();
                    break;

                case "2":
                    get_description_of_games.DescriptionOfGames();
                    break;

                case "3":
                    get_creator_information.CreatorInformation();
                    break;

            }
        }
    }
}