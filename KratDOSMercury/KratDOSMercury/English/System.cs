using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KratOS
{
    class Sys
    {
        public const bool CameWithMachine = true;
        public const string PCName = "KratPPC";
        public static void lmod()
        {
            Console.Write("Select Language/Selecte la langue>");var lang = Console.ReadLine();
        if (lang == "fr")
            {
                Console.Clear();
                Console.Write("KratDOS sont en francais... Ceci est le prompte du commande -- ");
                KratDOSMercury.frKernel.Run();
            }

        else if (lang == "en")
            {
                Console.Clear();
                Console.Write("KratDOS is in english... Rebooting ");
                Cosmos.System.Power.Reboot();
            }
        else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("KRATOS EXP: 204588 - INPUTINVLD: LANGUAGE NOT VALID/NOT SPECIFIED");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void GTNL()
        {
            
        }
        public static void Credits()
        {
            Console.WriteLine("");
            Utilities.drawlistitem(">", "Jacob Caravaggio", "Design");
            Console.WriteLine("");
        }
        public static void frCredits()
        {
            Console.WriteLine("");
            Utilities.drawlistitem(">", "Jacob Caravaggio", "Conceptment du l'ordi et le traduction du sys. exp.");
            Console.WriteLine("");
        }
    }
}
