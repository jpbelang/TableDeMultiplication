using System;
using System.Collections.Generic;

namespace Overrider
{
    class Personne
    {
        private String name;
        private int age;
        private Personne conjoint;

        public Personne(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        /*
            La methode qui permet le mariage.  Le nouveau conjoint est l'autre:  la personne a marier.  this est le
            moi-meme qui va marier le nouveau conjoint.
        */
        public void Marier(Personne nouveauConjoint)
        {
            // Quelques verification:  je ne me marie pas a moi meme, je ne suis pas deja marie, et j'ai un
            // vrai conjoint non null.
            if (nouveauConjoint == this || nouveauConjoint == null || nouveauConjoint.conjoint != null )
            {
                throw new ArgumentException("Beurk...");
            }

            conjoint = nouveauConjoint;
            nouveauConjoint.conjoint = this;
        }

        /*
            On fait un "override" su le methode d'object "ToString". L'override dit a .NET que tout appel a ToString()
            sur une instance de Personne doit etre routee ici.

            Remarquez que plein de fonctions .NET appelent ToString:  Console.WriteLine(), par exemple fait un ToString()
            sur tout objet qui lui est passe.  De meme quand on fait "blah " + instancePersonne + " blah".  Si vous enlevez le
            mot-cle override, ces methodes ne fonctionneront plus et vous aurez le defaut: [Overrider.Personne]
        */
        public override String ToString()
        {
            return name + " (" + age + ") " + (conjoint != null);
        }

        public static void Main(string[] args)
        {
            Personne p1 = new Personne("Paul", 18);
            Personne p2 = new Personne("Paule", 18);

            p2.Marier(p1);
            Console.WriteLine(p1);
        }
    }
}