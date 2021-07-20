using System;
using AutoUpdaterDotNET;

namespace autoupdateTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoUpdater.Start("https://raw.githubusercontent.com/sanchit1591/autoupdateTrial/master/updater.xml");
            Console.WriteLine("Hello World!");
        }
    }
}
