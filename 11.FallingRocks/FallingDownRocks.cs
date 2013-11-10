using System;
using System.Collections.Generic;

class FallingDownRocks
{
    private List<Rock> fallingDownRock = new List<Rock>();
    private int result = 0;
    public FallingDownRocks(int firstRock = 3)
    {
        for (int i = 0; i < firstRock; i++)
        {
            this.fallingDownRock.Add(new Rock(RandomPosition()));
        }
    }
    public bool Drow(int x, int y)
    {
        List<Rock> itemsForRemove = new List<Rock>();
        bool result = true;
        foreach (var item in this.fallingDownRock)
        {
            if (x <= item.xPosition() && item.xPosition() <= (x + 2) && item.yPosition() == y)
            {
                result = false;
            }
            bool current = item.Drow();
            
            if (!current)
            {
                itemsForRemove.Add(item);
            }
            
        }
        ItemsToRemove(itemsForRemove);
        DrowResults();
        AddNewItem();
        return result;
    }

    private void ItemsToRemove(List<Rock> itemsForRemove)
    {
        foreach (var item in itemsForRemove)
        {
            this.fallingDownRock.Remove(item);
            this.result++;
        }
    }
    public void DrowResults()
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Result: {0}", this.result);
    }
    private void AddNewItem()
    {
        this.fallingDownRock.Add(new Rock(RandomPosition()));
    }
    private int RandomPosition()
    {
        Random next = new Random();
        return next.Next(0, Console.WindowWidth);
    }
}
