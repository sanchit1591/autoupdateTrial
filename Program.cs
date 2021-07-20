using System;
using AutoUpdaterDotNET;

namespace autoupdateTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoUpdater.Start("https://github.com/sanchit1591/autoupdateTrial/blob/master/updater.xml");
            Console.WriteLine("Hello World!");
        }
    }
}
