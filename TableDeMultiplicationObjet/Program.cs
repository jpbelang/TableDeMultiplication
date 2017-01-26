using System;
using System.Collections.Generic;

namespace TableDeMultiplicationObjet
{
    /*
        Une classe est un concept, une idée.  Ici, l'idée est une table de multiplication.
    */
    public class TableDeMultiplication
    {
        /*
            Une table de multiplication ne contient qu'un seul attribut:  le facteur de multiplication.
            Quand on parle d'une table de multiplication,  on dit "table de X". Facteur est le X.
        */
        private readonly int facteur;

        /*
            Ici, on trouve un constructeur.  On sait que c'est un constructeur parce que son nom est identique
            au nom de la classe.  Il n'a qu'un seul argument:  le facteur.
        */
        public TableDeMultiplication(int facteur)
        {
            /*
                "facteur", c'est le nom de l'argument. "this.facteur", c'est le nom de l'attribut.
            */
            this.facteur = facteur;
        }

        /*
            La seule méthode de la classe.  Elle ne fait qu'afficher la table.
        */
        public void AfficheTable()
        {
            for (int a = 0; a <= 9; a++)
            {
                Console.WriteLine(a + " x " + facteur + " = " +  a * facteur);
            }
        }

        public static void Main(string[] args)
        {
            int facteur = Int32.Parse(args[0]);
            // On créé une premiere "instance" de la table.  Chaque instance occupe une place
            // différente en mémoire.
            TableDeMultiplication tableUn = new TableDeMultiplication(facteur);
            tableUn.AfficheTable();

            // UNe seconde table de multiplication.  Différente de la premiere.
            int autreFacteur = Int32.Parse(args[1]);
            TableDeMultiplication tableDeux = new TableDeMultiplication(autreFacteur);
            tableDeux.AfficheTable();
        }
    }
}