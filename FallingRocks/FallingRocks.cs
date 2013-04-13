using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct Rock
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}
struct Dwarf
{
    public int x;
    public int y;
    public string str;
    public ConsoleColor color;
}


class FallingRocks
{
    static void PrintSymbol(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintString(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main(string[] args)
    {
        int playfieldWidth = 21;
        int lifeCount = 3;
        int scoreCounter = 0;
        int score = 0;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 33;
        Dwarf dwarf = new Dwarf();
        dwarf.x = 10;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.str = "(0)";
        dwarf.color = ConsoleColor.White;
        Random ramNums = new Random();
        List<Rock> rocks = new List<Rock>();

        while (true)
        {
            scoreCounter++;

            //create new rock
            ConsoleColor[] cslcolor = new ConsoleColor[10] { ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.DarkCyan, ConsoleColor.DarkBlue, ConsoleColor.Cyan };
            char[] rockType=new char[11]{'^','@','*','&','+','%','$','#','!','.',';'};
            Rock newRock = new Rock();
            newRock.color = cslcolor[ramNums.Next(0, 10)];
            newRock.x = ramNums.Next(0, 21);
            newRock.y = 0;
            newRock.c = rockType[ramNums.Next(0, 11)];
            rocks.Add(newRock);
            //clear board
            Console.Clear();
            //dwarf moving
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                { 
                    Console.ReadKey();
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }

                }
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 3 <= playfieldWidth)
                    {
                        dwarf.x = dwarf.x + 1;
                    }

                }

            }
            //rocks falling and collision
            List<Rock> newList = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock currentRock = new Rock();
                currentRock.x = oldRock.x;
                currentRock.y = oldRock.y + 1; ;
                currentRock.c = oldRock.c;
                currentRock.color = oldRock.color;
                if (currentRock.y == dwarf.y && ((currentRock.x == dwarf.x) || (currentRock.x == dwarf.x + 1) || (currentRock.x == dwarf.x + 2)))
                {
                    lifeCount--;
                    score = score - 5;
                    if (score < 0) score = 0;
                    if (lifeCount <= 0)
                    {
                        PrintString(21, 8, "Game Over");
                        Console.ReadLine();
                        return;
                    }
                }
                if (currentRock.y < Console.WindowHeight)
                {
                    newList.Add(currentRock);
                }
            }
            rocks = newList;
            
            //draw board
            PrintString(dwarf.x, dwarf.y, dwarf.str, dwarf.color);
            foreach (Rock rock in rocks)
            {
                PrintSymbol(rock.x, rock.y, rock.c, rock.color);
            }

            //statistics
            PrintString(22, 5, "Lives: " + lifeCount, ConsoleColor.White);
            if (scoreCounter % 10 == 0) score++;
            PrintString(22, 7, "Score: " + score, ConsoleColor.White);

            //delay
            Thread.Sleep(500);
        }

    }
}

