using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KratDOSMercury
{
    class frKernel
    { 
        public static void Run()
        {
            while (true)
            {
                Console.Write(Strings.Prompt); var input = Console.ReadLine();
                if (input == "aide")
                {
                    Commands.frhelp("os");
                }
                else if (input == "command" || input == "oem")
                {
                    Commands.Command("KratDOS Mercury", "2.28", "KratOS Operating Systems Group", 2016);
                }
                else if (input == "oem credits")
                {
                    KratOS.Sys.frCredits();
                }
                else if (input == "vide")
                {
                    Console.Clear();
                }
                else if (input == "dmod")
                {
                    Commands.Monitor.frModify();
                }
                else if (input == "lmod")
                {
                    KratOS.Sys.lmod();
                }
                else
                {
                    if (input == "" || input == " " || input == null)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Commands.frbadcmd();
                    }
                }
            }
        }
    }
}
