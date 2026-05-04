using IntroClasses;

public class Program
{
    public static void Main()
    {
        //2. Dodanie funkcji do zamykania pętli, jej nazwa odpowiada przy ConsoleKey.Q na końcu pętli, żeby ją zamknąć
        bool isPlaying = true;
        Vector2 startingPosition = new Vector2(4, 2);
        Character hero = new Player(startingPosition);
        //4.7 "zakomentowanie chwilowe" startingPosition = new Vector2(0, 0);
        startingPosition.X = 0;
        startingPosition.Y = 0;
        //4.7 stworzenie nowego objektu/postaci
        Character anotherHero = new Npc(startingPosition);
        List<Character> characters = [hero, anotherHero];

        foreach (Character character in characters)
        {
            character.Display();
        }
        
        //5. hero.Display();
        //5. anotherHero.Display();
        //2. Dodanie pętli, po dodaniu Console.ReadKey
        while (isPlaying)
        {
            //3.1 stworzenie nowej metody usnięcie tego, co tu było wcześniej - ruchów awatara - i skopiowanie do player.cs
            //3.1 na początku "hero." będzie czerwone trzeba kliknąć ctrl + . -> create method -> stworzy się nowy "public void TakeTurn" w player.cs
            //3.1 nowa metoda tworzy więcej możliwości na przerwanie gry
            //5. isPlaying = hero.TakeTurn();
            //5. isPlaying = anotherHero.TakeTurn();
            foreach (Character character in characters)
            {
                isPlaying = character.TakeTurn();
            }
        }

        Console.WriteLine("Goodbye!");
    }
}