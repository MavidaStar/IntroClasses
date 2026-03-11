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
}
