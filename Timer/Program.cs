using System;
using System.Collections.Generic;
using System.Timers;

namespace Timer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer(10000);
            timer.Elapsed += new ElapsedEventHandler((source, eventObject) =>{System.Environment.Exit(200);});
            timer.Start();

            Console.WriteLine("Hello ?");
            Console.ReadKey();
        }
    }
}