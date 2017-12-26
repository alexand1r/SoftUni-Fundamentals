using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Speech.Synthesis;

struct gameObject
{
    public int x;
    public int y;
    public string symbol;
    public ConsoleColor color;
}

class Program
{
    static void StartScreen() 
    {
        PrintPosition(Console.BufferWidth / 2 - 17, Console.BufferHeight / 2 - 9, @" _____                      __     ", ConsoleColor.Red);
        PrintPosition(Console.BufferWidth / 2 - 17, Console.BufferHeight / 2 - 8, @"|  __ \                    / _|   ", ConsoleColor.Red);
        PrintPosition(Console.BufferWidth / 2 - 17, Console.BufferHeight / 2 - 7, @"| |  | |_      ____ _ _ __| |_ ___ ", ConsoleColor.Red);
        PrintPosition(Console.BufferWidth / 2 - 17, Console.BufferHeight / 2 - 6, @"| |  | \ \ /\ / / _` | '__|  _/ __|", ConsoleColor.Red);
        PrintPosition(Console.BufferWidth / 2 - 17, Console.BufferHeight / 2 - 5, @"| |__| |\ V  V / (_| | |  | | \__ \ ", ConsoleColor.Red);
        PrintPosition(Console.BufferWidth / 2 - 17, Console.BufferHeight / 2 - 4, @"|_____/  \_/\_/ \__,_|_|  |_| |___/", ConsoleColor.Red);
        Console.Beep(392, 350);Thread.Sleep(100);
        Console.Beep(392, 350);Thread.Sleep(100);
        Console.Beep(392, 350);Thread.Sleep(100);
        Console.Beep(311, 250);Thread.Sleep(100);
        Console.Beep(466, 25);Thread.Sleep(100);
        Console.Beep(392, 350);Thread.Sleep(100);
        Console.Beep(311, 250);Thread.Sleep(100);
        Console.Beep(466, 25);Thread.Sleep(100);
        Console.Beep(392, 700);Thread.Sleep(100);
        
        PrintPosition(Console.BufferWidth / 2 - 17, Console.BufferHeight / 2 + 8, "Press [ENTER] to start the game\n", ConsoleColor.Red);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.ReadKey();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo startKey = Console.ReadKey(true);
                if (startKey.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
    static void PrintPosition(int x, int y, string symbol,ConsoleColor color=ConsoleColor.DarkRed)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor=color;
        Console.Write(symbol);
    }
    static bool Check(int y, int y2,int x,int x2)
    {
        bool test1 = y == y2 && x == x2;
        bool test2 = y == y2 && (x + 1) == x2;
        bool test3 = y == y2 && (x + 2) == x2;
        bool result = test1 || test2 || test3;
        return result;
    }
    static void Main()
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        Console.Title="Dwarfs";
        int gameBoard = 78;
        int lives = 3;
        int score = 0;
        int difficulty = 0;
        var rndColor = new Random();
        Random rndLoc = new Random();
        string[] rockMas = new string[11] { "^", "@", "&", "+", "%", "$", "#", "!", ".", ";","*"};
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 80;
        gameObject dwarf = new gameObject();
        List<gameObject>rocks=new List<gameObject>();
        dwarf.x = 5;
        dwarf.y = Console.WindowHeight-1;
        dwarf.symbol ="(0)";
        dwarf.color = ConsoleColor.Gray;
        Console.BackgroundColor = ConsoleColor.Black;
        StartScreen();
        while (lives>0)
        {
            score += 1;
            bool hit = false;
            int chance = rndLoc.Next(0, 100);
            {
                if (chance<3)
                {
                    gameObject oneUp = new gameObject();
                    oneUp.x = rndLoc.Next(2, gameBoard);
                    oneUp.y = 2;
                    oneUp.symbol="U";
                    oneUp.color = ConsoleColor.Green;
                    rocks.Add(oneUp);
                }
                else if (chance<15)
	            {
		            gameObject oneK = new gameObject();
                    oneK.x = rndLoc.Next(2, gameBoard);
                    oneK.y = 2;
                    oneK.symbol="K";
                    oneK.color = ConsoleColor.Yellow;
                    rocks.Add(oneK);
	            }
                else
                {
                    int size = rndLoc.Next(0, difficulty+2);
                    int spawn = rndLoc.Next(0,(gameBoard / 15)+difficulty);
                    for (int i = 0; i < spawn; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            gameObject rock = new gameObject();
                            rock.x = rndLoc.Next(2, gameBoard);
                            rock.y = 2;
                            rock.color = (ConsoleColor)rndColor.Next((int)ConsoleColor.Blue, (int)ConsoleColor.Yellow);
                            rock.symbol = rockMas[rndLoc.Next(0, 11)];
                            rocks.Add(rock);
                            if (rock.x>gameBoard)
                            {
                                rock.x = 0;
                            }
                        }
                    }
                }
            }
            Console.SetCursorPosition(0, 1);
            if (score > 20000)
            {
                difficulty = 1;
            }
            else if (score>40000)
            {
                difficulty = 2;
            }
            string header = "Lives: "+lives+ " Score: "+score+" Difficulty: "+difficulty;
            PrintPosition(0,1,"Lives",ConsoleColor.White);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x-1>=2)
                    {
                        dwarf.x = dwarf.x-1;
                    }
                    else if (dwarf.x-1<2)
                    {
                        dwarf.x = gameBoard-2;//Pac-man style transition from one end of the game board to the other.
                    }
                }
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if(dwarf.x + 1 > gameBoard-2)
                   {
                       dwarf.x = 0+2; //Pac-man style transition from one end of the game board to the other.
                   }
                   else 
                   {
                       dwarf.x = dwarf.x + 1;
                   }
                }
            }
            List<gameObject> newRockList = new List<gameObject>();
            Console.Clear();
            for (int i = 0; i < rocks.Count; i++)
            {
                gameObject tempRock = rocks[i];
                gameObject newRock = new gameObject();
                newRock.x = tempRock.x;
                newRock.y = tempRock.y + 1;
                newRock.symbol = tempRock.symbol;
                newRock.color = tempRock.color;
                newRockList.Add(newRock);
                Check(dwarf.y,newRock.y,dwarf.x,newRock.x);
                if (newRock.symbol == "U" && Check(dwarf.y, newRock.y, dwarf.x, newRock.x)) 
                {
                    lives+=1;
                }
                else if (newRock.symbol == "K" && Check(dwarf.y, newRock.y, dwarf.x, newRock.x)) 
                {
                    score+=500;
                }
                else if (Check(dwarf.y,newRock.y,dwarf.x,newRock.x)) 
                {
                    lives--;
                    hit = true;                    
                }
                if (newRock.y>=Console.WindowHeight)
                {
                    newRockList.Remove(newRock);
                }
            }
            rocks = newRockList;            
            foreach (gameObject rockObj in rocks)
            {
                PrintPosition(rockObj.x, rockObj.y, rockObj.symbol, rockObj.color);
            }
            if (hit == true)
            {
                rocks.Clear();
                PrintPosition(dwarf.x, dwarf.y, "<X>", ConsoleColor.DarkRed);
            }
            else
            {
                PrintPosition(dwarf.x, dwarf.y, dwarf.symbol, dwarf.color);
            }
            for (int i = 0; i < Console.BufferHeight-1; i++)
            {
                PrintPosition(1, i, "░", ConsoleColor.Cyan);
                PrintPosition(Console.BufferWidth-1, i, "░", ConsoleColor.Cyan);
            }
            PrintPosition(0, 0, header, dwarf.color);
            Thread.Sleep(150);
        }
        if (lives==0)
        {
            Console.Clear();
            
            PrintPosition(Console.BufferWidth / 2 - 25, Console.BufferHeight / 2 - 4, @"  _____                         ____                ", ConsoleColor.Red);
            PrintPosition(Console.BufferWidth / 2 - 25, Console.BufferHeight / 2 - 3, @" / ____|                       / __ \              ", ConsoleColor.Red);
            PrintPosition(Console.BufferWidth / 2 - 25, Console.BufferHeight / 2 - 2, @"| |  __  __ _ _ __ ___   ___  | |  | |_   _____ _ __ ", ConsoleColor.Red);
            PrintPosition(Console.BufferWidth / 2 - 25, Console.BufferHeight / 2 - 1, @"| | |_ |/ _` | '_ ` _ \ / _ \ | |  | \ \ / / _ \ '__|", ConsoleColor.Red);
            PrintPosition(Console.BufferWidth / 2 - 25, Console.BufferHeight / 2, @"| |__| | (_| | | | | | |  __/ | |__| |\ V /  __/ |", ConsoleColor.Red);
            PrintPosition(Console.BufferWidth / 2 - 25, Console.BufferHeight / 2 + 1, @" \_____|\__,_|_| |_| |_|\___|  \____/  \_/ \___|_|", ConsoleColor.Red);
            PrintPosition(Console.BufferWidth / 2 - 7, Console.BufferHeight / 2+3, "Your score was: "+score, ConsoleColor.Green);
            PrintPosition(Console.BufferWidth / 2 - 15, Console.BufferHeight / 2 + 6, "", ConsoleColor.Green);

            //End screen theme - Yep Star Wars.
           Console.Beep(1174, 400); 
           Console.Beep(1174, 200); 
           Console.Beep(1567, 400); 
           Console.Beep(1396, 200); 
           Console.Beep(1244, 400); 
           Console.Beep(1174, 200); 
           Console.Beep(1046, 400); 
           Console.Beep(923, 200);  
           Console.Beep(880, 400);  
           Console.Beep(783, 200);  
           Console.Beep(1174, 600);
           for (int x = 0; x < 3; x++)
           {
               Console.Beep(880, 200);  
           }
           Console.Beep(880, 600);  

        }
    } 
}
