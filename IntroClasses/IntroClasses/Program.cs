using IntroClasses;

public class Program
{
    public static void Main()
    {
        //2. Dodanie funkcji do zamykania pętli, jej nazwa odpowiada przy ConsoleKey.Q na końcu pętli, żeby ją zamknąć
        bool isPlaying = true;
        Player hero = new Player();
        hero.Display();
        //2. Dodanie pętli, po dodaniu Console.ReadKey
        while (isPlaying)
        {
            //3.1 stworzenie nowej metody usnięcie tego, co tu było wcześniej - ruchów awatara - i skopiowanie do player.cs
            //3.1 na początku "hero." będzie czerwone trzeba kliknąć ctrl + . -> create method -> stworzy się nowy "public void TakeTurn" w player.cs
            //3.1 nowa metoda tworzy więcej możliwości na przerwanie gry
            isPlaying = hero.TakeTurn();
        }

        Console.WriteLine("Goodbye!");
    }
}