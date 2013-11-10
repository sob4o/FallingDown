using System;
class Rock
{
    private Position rockPosition;
    private char symbol;
    private ConsoleColor backGround;
    public int xPosition()
    {
        return this.rockPosition.X;
    }
    public int yPosition()
    {
        return this.rockPosition.Y;
    }
    public Rock(int positionX)
    {
        this.rockPosition.X = positionX;
        this.rockPosition.Y = 0;
        this.symbol = RamdomSymbol();
        backGround = RandomColor();
    }
    private ConsoleColor RandomColor()
    {
        Random next = new Random();
        ConsoleColor color = (ConsoleColor) next.Next(0, 16);
        if(ConsoleColor.Black == color)
        {
            color++;
        }
        return color;
    }
       
    private char RamdomSymbol()
    {
        char[] symbols = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        Random next = new Random();
        return symbols[next.Next(0, symbols.Length - 1)];
    }
    public bool Drow()
    {
        Console.SetCursorPosition(this.rockPosition.X, this.rockPosition.Y++);
        if(this.rockPosition.Y >= Console.WindowHeight)
        {
            return false;
        }
        Console.ForegroundColor = this.backGround;
        Console.Write(this.symbol);
        return true;
    }
}
