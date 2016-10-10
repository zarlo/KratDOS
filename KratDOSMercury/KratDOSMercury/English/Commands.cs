using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Commands
    {
    public static void Command(string OSName, string OSVer, string OSCmpny, int Year)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(OSName + " " + OSVer + ". " + OSCmpny + ". " + Year);
    }
    public static void help(string type)
    {
        if (type == "os")
        {
            Console.WriteLine("");
            Utilities.drawlistitem(">", "help", "Displays Help Prompt");
            Utilities.drawlistitem(">", "command", "Kills the command prompt and draws a new instance");
            Utilities.drawlistitem(">", "power", "Modifies the power state of the operating system");
            Utilities.drawlistitem(">", "devices", "Displays Devices");
            Utilities.drawlistitem(">", "cls", "Clear screen");
            Utilities.drawlistitem(">", "oem", "View Computer Info");
            Utilities.drawlistitem(">", "dmod", "Modify the display settings (Must have color monitor)");
            Utilities.drawlistitem(">", "lmod", "Modify the language settings");
            Console.WriteLine("");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("KRATOS EXP: 20464 - SRCCDEINVLD: HELP PARAM TYPE");
        }
    }
    public static void frhelp(string type)
    {
        if (type == "os")
        {
            Console.WriteLine("");
            Utilities.drawlistitem(">", "aide", "Il motre le page du l'aide");
            Utilities.drawlistitem(">", "command", "Il tue le system d'exploitation et le refait");
            Utilities.drawlistitem(">", "energie", "Il modifie l'etat du l'energie");
            Utilities.drawlistitem(">", "appareils", "Il montre tous les appareils");
            Utilities.drawlistitem(">", "vide", "Il rendre l'ecran vide avec l'invite de commande");
            Utilities.drawlistitem(">", "oem", "Il montre l'information du l'ordinateur");
            Utilities.drawlistitem(">", "dmod", "Il modifie les parametres du l'ecran (Tu dois avoir un ecran du couleur)");
            Utilities.drawlistitem(">", "lmod", "Il modifie les parametres du la langue");
            Console.WriteLine("");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("KRATOS EXP: 20464 - SRCCDEINVLD: HELP PARAM TYPE");
        }
    }
    public static void frbadcmd()
    {
        BadCmd();
    }
    public static void BadCmd()
        {
            Console.WriteLine("Bad command or file name.");
        }
    public static void BadArg()
    {
        Console.WriteLine("Bad argument or switch.");
    }
    public class Monitor
    {
        public static void Modify(string back, string fore)
        {
            #region ModifyForeground
            if (fore == "0")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                 
            }
            else if (fore == "1")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                 
            }
            else if (fore == "2")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                 
            }
            else if (fore == "3")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                 
            }
            else if (fore == "4")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                 
            }
            else if (fore == "5")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                 
            }
            else if (fore == "6")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                 
            }
            else if (fore == "7")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                 
            }
            else if (fore == "8")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                 
            }
            else if (fore == "9")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                 
            }
            else if (fore == "a" || fore == "10")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                 
            }
            else if (fore == "b" || fore == "11")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                 
            }
            else if (fore == "c" || fore == "12")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                 
            }
            else if (fore == "d" || fore == "13")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                 
            }
            else if (fore == "e" || fore == "14")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                 
            }
            else if (fore == "f" || fore == "15")
            {
                Console.ForegroundColor = ConsoleColor.White;
                 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                 
            }
            #endregion
            #region ModifyBackground
            if (back == "0")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
            else if (back == "1")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
            }
            else if (back == "2")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                }
            else if (back == "3")
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Clear();
                }
            else if (back == "4")
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                }
            else if (back == "5")
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                }
            else if (back == "6")
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                }
            else if (back == "7")
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Clear();
                }
            else if (back == "8")
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                }
            else if (back == "9")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                }
            else if (back == "a"||back == "10")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                }
            else if (back == "b" || back == "11")
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                }
            else if (back == "c" || back == "12")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                }
            else if (back == "d" || back == "13")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                }
            else if (back == "e" || back == "14")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                }
            else if (back == "f" || back == "15")
            {
                Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            #endregion
        }
        public static void Modify()
        {
            Utilities.ColorDebug();
            Console.Write("Enter Back Colour >"); var back = Console.ReadLine();
            Console.Write("Enter Fore Colour >"); var fore = Console.ReadLine();
            Commands.Monitor.Modify(back, fore);
        }
        public static void frModify()
        {
            Utilities.ColorDebug();
            Console.Write("Entre le couleur du l'ecran >"); var back = Console.ReadLine();
            Console.Write("Entre le couleur du le texte >"); var fore = Console.ReadLine();
            Commands.Monitor.Modify(back, fore);
        }
    }
    }