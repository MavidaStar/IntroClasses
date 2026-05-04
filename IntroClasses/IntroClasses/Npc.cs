namespace IntroClasses;

public class Npc : Character
{
    public Npc(Vector2 startingPosition) : base(startingPosition)
    {
        
    }

    public override bool TakeTurn()
    {
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(" ");
        Move(diffX:1, diffY:0);
        Display();
        return true;
    }
}