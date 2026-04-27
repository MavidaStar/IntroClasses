using IntroClasses;

public class Program
{
    public static void Main()
    {
        //2. Dodanie funkcji do zamykania pętli, jej nazwa odpowiada przy ConsoleKey.Q na końcu pętli, żeby ją zamknąć
        bool isPlaying = true;
        Vector2 startingPosition = new Vector2(4, 2);
        Player hero = new Player(startingPosition);
        //4.7 "zakomentowanie chwilowe" startingPosition = new Vector2(0, 0);
        startingPosition.X = 0;
        startingPosition.Y = 0;
        //4.7 stworzenie nowego objektu/postaci
        Player anotherHero = new Player(startingPosition);
        
        hero.Display();
        anotherHero.Display();
        //2. Dodanie pętli, po dodaniu Console.ReadKey
        while (isPlaying)
        {
            //3.1 stworzenie nowej metody usnięcie tego, co tu było wcześniej - ruchów awatara - i skopiowanie do player.cs
            //3.1 na początku "hero." będzie czerwone trzeba kliknąć ctrl + . -> create method -> stworzy się nowy "public void TakeTurn" w player.cs
            //3.1 nowa metoda tworzy więcej możliwości na przerwanie gry
            isPlaying = hero.TakeTurn();
            isPlaying = anotherHero.TakeTurn();
        }

        Console.WriteLine("Goodbye!");
    }
}