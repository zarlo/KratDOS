using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;
public class Kernel : Sys.Kernel
{
    public string[] GetFsFadr(string Adr) // Get Files From Address
    {
        string[] Files = new string[256];
        if (Directory.GetFiles(Adr).Length > 0)
            Files = Directory.GetFiles(Adr);
        else
            Files[0] = "No files found.";
        return Files;
    }
    public string[] GetDirFadr(string Adr) // Get Directories From Address
    {
        var Dirs = Directory.GetDirectories(Adr);
        return Dirs;
    }
    protected override void BeforeRun()
    {
        Console.Clear();
        Console.WriteLine("Welcome to KratDOS");
        var fs = new Sys.FileSystem.CosmosVFS();
        Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
    }
    protected override void Run()
    {
        Utilities.drawlistitem("#", Directory.GetCurrentDirectory() + ">");
        var input = Console.ReadLine();
        if (input == "help")
        {
            Commands.help("os");
        }
        else if (input == "command" || input == "oem")
        {
            Commands.Command("KratDOS Mercury", "2.3", "KratOS Operating Systems Group", 2016);
        }
        else if (input == "oem credits")
        {
            KratOS.Sys.Credits();
        }
        else if (input == "oem status")
        {
            if (KratOS.Sys.CameWithMachine)
            {
                Utilities.drawlistitem(">", "This PC is OEM", "KratOS.Sys.CameWithMachine == true;");
            }
        }
        else if (input == "cls")
        {
            Console.Clear();
        }
        else if (input == "dmod")
        {
            Commands.Monitor.Modify();
        }
        else if (input == "lmod")
        {
            KratOS.Sys.lmod();
        }
        else if (input == "dir" || input == "ls")
        {
            foreach (var item in GetDirFadr(Directory.GetCurrentDirectory()))
            {
                Utilities.drawlistitem(">", item.ToString(), "DIR");
            }
            foreach (var item in GetFsFadr(Directory.GetCurrentDirectory()))
            {
                Utilities.drawlistitem(">", item.ToString(), "FILE");
            }
        }
        else
        {
            if (input == "" || input == " " || input == null)
            {
                KratOS.Sys.GTNL();
            }
            else
            {
                Commands.BadCmd();
            }
        } 
    }
    

}
