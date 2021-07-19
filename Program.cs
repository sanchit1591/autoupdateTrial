using System;
using AutoUpdaterDotNET;

namespace autoupdateTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoUpdater.Start("https://github.com/sanchit1591/autoupdateTrial/XMLFile1.xml");
            Console.WriteLine("Hello World!");
        }
    }
}
