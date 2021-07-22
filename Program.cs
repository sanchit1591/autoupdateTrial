using System;
using AutoUpdaterDotNET;

namespace autoupdateTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoUpdater.Synchronous = true;
            AutoUpdater.Start("https://raw.githubusercontent.com/sanchit1591/test-.netCore/main/updater.xml");
            Console.WriteLine("Hello Worlda!");
        }
    }
}
