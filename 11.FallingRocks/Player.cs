using System;
public class Player
{
    Position playerPosition;
    private string playerSymbols;

    public Player()
    {
        this.playerSymbols = "(0)";
        this.playerPosition.X = (Console.WindowWidth / 2) - 1;
        this.playerPosition.Y = Console.WindowHeight - 2;
    }
    public string PlayerSymbols
    {
        get
        {
            return this.playerSymbols;
        }
    }
    public int XPlayerPosition()
    {
        return this.playerPosition.X;
    }
    public int YPlayerPosition()
    {
        return this.playerPosition.Y;
    }
    public void Drow()
    {
        Console.SetCursorPosition(this.playerPosition.X, this.playerPosition.Y);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(this.playerSymbols);
    }
    public void Move(ConsoleKey key)
    {
        if(key == ConsoleKey.LeftArrow)
        {
            if(0 < this.playerPosition.X - 1)
            {
                playerPosition.X--;
            }
        }
        else if(key == ConsoleKey.RightArrow)
        {
            if (this.playerPosition.X < Console.WindowWidth - PlayerSymbols.Length)
            {
                playerPosition.X++;
            }
        }
    }
}
