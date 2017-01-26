using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace TableDeMultiplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int facteur = Int32.Parse(args[0]);
            AfficheTableMultiplication(facteur);
        }


        public static void AfficheTableMultiplication(int facteur)
        {

            for (int a = 0; a <= 9; a++)
            {
                Console.WriteLine(a + " x " + facteur + " = " +  a * facteur);
            }
        }
    }
}