using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0919_órai
{
    internal class Program
    {
        static int x = 1, y = 7, cursorPosX = 0, cursorPosY = 0;
        static void Main(string[] args)
        {
            string color = "Character color is: ";
            string character = "The set character is: ";
            char setCharacter = '░';
            Console.Write(color + "white    ");
            Console.Write("\n" + character + setCharacter);
            Console.Write("\nPlace characters with spacebar.");
            Console.Write("\nChange character color with numbers (1-5).");
            Console.Write("\nChange characters with letters (Q,W,E,R).");
            Console.SetCursorPosition(x, y);
            bool escPress = false;
            while (!escPress)
            { 
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        escPress = true;
                        break;
                    case ConsoleKey.DownArrow:
                        if(Console.CursorTop < Console.WindowHeight-1)
                        {
                            Console.CursorTop += 1;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if(Console.CursorTop <= Console.WindowHeight-1 && Console.CursorTop > 0)
                        {
                            Console.CursorTop -= 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft < Console.WindowWidth - 1)
                        {
                            Console.CursorLeft += 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft <= Console.WindowWidth - 1 && Console.CursorLeft > 0)
                        {
                            Console.CursorLeft -= 1;
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write(setCharacter);
                        break;
                    case ConsoleKey.D1:
                        Console.ForegroundColor = ConsoleColor.White;
                        cursorPosX = Console.CursorLeft;
                        cursorPosY = Console.CursorTop;
                        Console.SetCursorPosition(0, 0);
                        Console.Write(color + "white  ");
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        break;
                    case ConsoleKey.D2:
                        cursorPosX = Console.CursorLeft;
                        cursorPosY = Console.CursorTop;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, 0);
                        Console.Write(color + "red    ");
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        break;
                    case ConsoleKey.D3:
                        cursorPosX = Console.CursorLeft;
                        cursorPosY = Console.CursorTop;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(0, 0);
                        Console.Write(color + "green   ");
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        break;
                    case ConsoleKey.D4:
                        cursorPosX = Console.CursorLeft;
                        cursorPosY = Console.CursorTop;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(0, 0);
                        Console.Write(color + "blue   ");
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        break;
                    case ConsoleKey.D5:
                        cursorPosX = Console.CursorLeft;
                        cursorPosY = Console.CursorTop;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(0, 0);
                        Console.Write(color + "magenta");
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        break;
                    case ConsoleKey.Q:
                        cursorPosX = Console.CursorLeft;
                        cursorPosY = Console.CursorTop;
                        setCharacter = '░';
                        Console.SetCursorPosition(0, 0);
                        Console.Write("\n" + character + setCharacter);
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        break;
                    case ConsoleKey.W:
                        cursorPosX = Console.CursorLeft;
                        cursorPosY = Console.CursorTop;
                        setCharacter = '▒';
                        Console.SetCursorPosition(0, 0);
                        Console.Write("\n" + character + setCharacter);
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        break;
                    case ConsoleKey.E:
                        cursorPosX = Console.CursorLeft;
                        cursorPosY = Console.CursorTop;
                        setCharacter = '▓';
                        Console.SetCursorPosition(0, 0);
                        Console.Write("\n" + character + setCharacter);
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        break;
                    case ConsoleKey.R:
                        cursorPosX = Console.CursorLeft;
                        cursorPosY = Console.CursorTop;
                        setCharacter = '█';
                        Console.SetCursorPosition(0, 0);
                        Console.Write("\n" + character + setCharacter);
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        break;
            //░▒▓█
                }
            }
        }
    }
}
