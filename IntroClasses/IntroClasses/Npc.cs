namespace IntroClasses;

public class Npc : Character
{
    List<Vector2> availableDirections = [
        new Vector2(-1, 0), // w lewo
        new Vector2(1, 0), // w prawo
        new Vector2(0, -1), // w górę
        new Vector2(0, 1) // w dół
    ];
    public Npc(Vector2 startingPosition) : base(startingPosition)
    {
        
    }

    public override bool TakeTurn(Map map)
    {
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(map.GetCell(_position.X, _position.Y).Visuals);

        int index = Random.Shared.Next(availableDirections.Count);
        Vector2 direction = availableDirections[index];
        Move(direction, map);
        Display();
        return true;
    }
}