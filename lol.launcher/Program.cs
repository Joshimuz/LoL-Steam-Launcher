using System;

namespace lol.launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening LeagueClient.exe");
            try
            {
                System.Diagnostics.Process lolclient = System.Diagnostics.Process.Start("LeagueClient.exe");
                Console.WriteLine("LeagueClient.exe found. This window will close when the game is exited.");
                lolclient.WaitForExit();
                Console.WriteLine("LeagueClient.exe was closed, this window will close in 5 seconds");
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not find LeagueClient.exe, please place inside the League of Legends root folder\nPress any key to close");
                Console.ReadLine();
            }
        }
    }
}
