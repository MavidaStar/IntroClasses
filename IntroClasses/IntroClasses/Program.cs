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
            // Console.ReadKey(true);
            //1. string input = Console.ReadLine()!; - w tym wypadku musieliśmy cały czas klikać enter, żeby móc się poruszać
            //2. Console.ReadKey - ruch gracza bez klikania w enter, czyli taki normalny
            ConsoleKeyInfo input = Console.ReadKey(true);
            //1. switch (input)
            switch (input.Key)
            {
                //1. case "s":
                case ConsoleKey.S:
                hero.Move(0, 1);
                break;
                //1. case "w":
                case ConsoleKey.W:
                hero.Move(0, -1);
                break;
                //1. case "a":
                case ConsoleKey.A:
                hero.Move(-1, 0);
                break;
                //2. case "d":
                case ConsoleKey.D:
                hero.Move(1, 0);
                break;
                //2. Dodanie ConsoleKey.Q: - zamykanie pętli
                case ConsoleKey.Q:
                    isPlaying = false;
                    break;
            }
                hero.Display();
        }

        Console.WriteLine("Goodbye!");
    }
}