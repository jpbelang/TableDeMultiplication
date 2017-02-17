using System;
using System.Collections.Generic;

namespace Formes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Canevas canevas = new SimpleCanevas();
            Carre carre1 = new Carre(2.0, 2.0, 1.0);
            Carre carre2 = new Carre(6.0, 6.0, 1.0);

            canevas.AjouterForme(carre1);
            canevas.AjouterForme(carre2);
            if (Math.Abs(canevas.CalculeSurfaceCouverte() - 2.0) > 0.1)
            {
                throw new ApplicationException("surface invalide " + canevas.CalculeSurfaceCouverte());
            }

            Cercle cercle = new Cercle(4.0, 8.0, 1.0);
            canevas.AjouterForme(cercle);
            if (Math.Abs(canevas.CalculeSurfaceCouverte() - (2.0 + Math.PI)) > 0.1)
            {
                throw new ApplicationException("surface invalide " + canevas.CalculeSurfaceCouverte());
            }

            try
            {
                Cercle cercleIllegal = new Cercle(2.1, 2.1, 1.0);
                canevas.AjouterForme(cercleIllegal);
                throw new ApplicationException("c'aurait du sauter...");
            }
            catch (ArgumentException e)
            {

            }

            Console.WriteLine("ok");
        }
    }
}