using System;
using System.Threading;
class FallingRocks
{
    static void Main()
    {
        while (true)
        {
            StartGame();
        }
    }

    private static void StartGame()
    {
        Player me = new Player();
        FallingDownRocks myRocks = new FallingDownRocks();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                me.Move(Console.ReadKey(true).Key);
            }
            me.Drow();
            if (!myRocks.Drow(me.XPlayerPosition(), me.YPlayerPosition()))
            {
                Console.ForegroundColor = ConsoleColor.White;
                NewGame();
                return;
            }
            Thread.Sleep(150);
            Console.Clear();
        }
    }
    static void NewGame()
    {
        string gameOver = "Game Over";
        string text = "Do you want to play again";
        string choos = @"Y/N";
        Console.SetCursorPosition((Console.WindowWidth - gameOver.Length) / 2, Console.WindowHeight / 2);
        Console.WriteLine(gameOver);
        Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, (Console.WindowHeight / 2) + 1);
        Console.Write(text);
        Console.SetCursorPosition(((Console.WindowWidth - choos.Length) / 2), (Console.WindowHeight / 2) + 2);
        Console.WriteLine(choos);
        Console.SetCursorPosition(((Console.WindowWidth - choos.Length) / 2), (Console.WindowHeight / 2) + 3);
        while (true)
        {

            if (Console.KeyAvailable)
            {
                ConsoleKey myKey = Console.ReadKey(true).Key;
                if (myKey == ConsoleKey.Y)
                {
                    return;
                }
                else if (myKey == ConsoleKey.N)
                {
                    System.Environment.Exit(1);
                }
            }

        }
    }
}
