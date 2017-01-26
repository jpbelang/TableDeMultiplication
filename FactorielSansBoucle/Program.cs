using System;
using System.Collections.Generic;

namespace FactorielSansBoucle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Factoriel de 3: " + factoriel(3) );
            Console.WriteLine("Factoriel de 9: " + factoriel(9) );
        }

        public static int factoriel(int valeur)
        {
            if (valeur == 0)
            {
                return 1;
            }

            return valeur * factoriel(valeur - 1);
        }
    }
}