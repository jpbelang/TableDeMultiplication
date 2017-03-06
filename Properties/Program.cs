using System;
using System.Collections.Generic;

namespace Properties
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Heure h = new Heure(10, 22, 17);
            h.heure = 9;

            // fails
            // h.second = 3;

            SmartHeure sh = new SmartHeure(11, 12, 13);
            sh.Heure = 44;
        }
    }
}