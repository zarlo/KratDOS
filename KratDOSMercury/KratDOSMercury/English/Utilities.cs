using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Utilities
{
    public static void ColorDebug()
    {
        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(0);
        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(1);
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(2);
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(3);
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(4);
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(5);
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(6);
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(7);
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(8);
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(9);
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("10/a");
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("11/b");
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("12/c");
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("13/d");
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("14/e");
        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("15/f");
    }
    public static void drawlistitem(string bullet, string text)
    {

        Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(bullet); Console.ForegroundColor = ConsoleColor.White; Console.Write(text);
        Console.WriteLine("");
    }
    public static void drawlistitem(string bullet, string text, string desc)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(bullet); Console.ForegroundColor = ConsoleColor.White; Console.Write(text);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green; Console.Write(" " + desc);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.White;
    }
}