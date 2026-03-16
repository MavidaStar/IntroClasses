namespace IntroClasses;

public class Player
{
    //2. Rename private in na nazwy z podłogą; ctrl + . albo F2
    //1. private int x;
    private int _x;
    //1. private int y;
    private int _y;
    //1. private string avatar = "@";
    private string _avatar = "@";

    public void Display()
    {
        //2. Dodanie Console.SetCursorPosition i Console.Write - x to kolumna, a y to wiersz (na odwrót jest)
        Console.SetCursorPosition(_x, _y);
        //1. Console.WriteLine(_avatar);
        //1. Console.WriteLine($"Position: {_x}, {_y}");
        Console.Write(_avatar);
    }

    public void Move(int diffX, int diffY)
    {
        _x += diffX;
        _y += diffY;
    }

    //public void TakeTurn() - oryginalnie, zmieniamy void na bool
    public bool TakeTurn()
    {
        //3.1 stwiorzenie funkcji bool isPlaying = true;
        bool isPlaying = true;
        //3.1 po skopiowaniu i wklejeniu z program.cs usunięcie wszędzie czerwonych "hero."
        // Console.ReadKey(true);
        //1. string input = Console.ReadLine()!; - w tym wypadku musieliśmy cały czas klikać enter, żeby móc się poruszać
        //2. Console.ReadKey - ruch gracza bez klikania w enter, czyli taki normalny
        ConsoleKeyInfo input = Console.ReadKey(true);
        //3. Dodanie pojawienia się spacji po RedKey i usunięcie Console.Clear - pojawianie się wcześniejszego miejsca avatara
        //3.1 Dodanie Console.SetCursorPosition(_x, _y)
        Console.SetCursorPosition(_x, _y);
        Console.Write(" ");
        //1. switch (input)
        switch (input.Key)
        {
            //1. case "s":
            case ConsoleKey.S:
                Move(0, 1);
                break;
            //1. case "w":
            case ConsoleKey.W:
                Move(0, -1);
                break;
            //1. case "a":
            case ConsoleKey.A:
                Move(-1, 0);
                break;
            //2. case "d":
            case ConsoleKey.D:
                Move(1, 0);
                break;
            //2. Dodanie ConsoleKey.Q: - zamykanie pętli
            case ConsoleKey.Q:
                isPlaying = false;
                break;
        }
        //3. Dodano Console.Clear(); - żeby wyczyścić poprzedni ruch avatara przed stworzeniem nowego;
        //bez tego jak się ruszaliśmy avatarem został on po sobie ślad, dzięki temu już go nie zostawia i faktycznie widać, że rusza się jak normalny gracz
        //Console.Clear(); 
        //usunięcie po dodaniu Console.Writeline(" ");
        Display();

        //3.1 Dodanie return isPalying;
        return isPlaying;
    }
}
