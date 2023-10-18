namespace MainPage;

public class Creator_Information
{
    public void CreatorInformation()
    {
        Navbar navbar = new Navbar();
        Dividingline dividingline = new Dividingline();
        Console.Clear();

        dividingline.Border();

        Console.WriteLine("Name:        Steiner Sebastian\n");
        Console.WriteLine("Alter:       16 Jahre\n");
        Console.WriteLine("Wohnort:     Burgenland (Österreich)\n");
        Console.WriteLine("Hobbys:      Coding, Kraftsport und Reisen\n");
        Console.WriteLine("Notiz:       Das ist mein Erstes eigenes Ausführliche C# Programm, das ich geschrieben habe.\n");

        dividingline.Border();
        navbar.Navigation();
    }
}