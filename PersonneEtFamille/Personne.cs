using System;
using System.Collections.Generic;

namespace PersonneEtFamille
{
    public class Personne
    {
        private string name;
        private int age;
        private Personne conjoint;
        private List<Personne> exConjoints = new List<Personne>();
        private Dictionary<string, Personne> enfants = new Dictionary<string, Personne>();

        public Personne(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Divorcer()
        {

            if (conjoint == null)
            {
                throw new ArgumentException("n'est pas conjoint....");
            }

            exConjoints.Add(conjoint);
            conjoint.exConjoints.Add(this);

            conjoint.conjoint = null;
            conjoint = null;
        }

        public int NomBreDeMariages()
        {
            if (conjoint != null)
            {
                return exConjoints.Count + 1;
            }
            else
            {
                return exConjoints.Count;
            }
        }

        public Personne Procreer(string nomEnfant)
        {
            if (conjoint == null)
            {
                throw new ArgumentException("n'est pas conjoint....");
            }

            // Est-ce que moi ou mon conjoint ont un enfant du meme nom que le nouvel enfant ?
            if (enfants.ContainsKey(nomEnfant) || conjoint.enfants.ContainsKey(nomEnfant))
            {
                throw new ArgumentException("enfant en double");

            }

            // Il est ne le nouvel enfant...
            Personne enfant = new Personne(nomEnfant, 0);

            // Les parents recoivent le nouvel enfant.
            enfants.Add(nomEnfant, enfant);
            conjoint.enfants.Add(nomEnfant, enfant);
            return enfant;
        }

        public Personne AppelerAuSouper(string nomEnfant)
        {
            if (enfants.ContainsKey(nomEnfant))
            {
                return enfants[nomEnfant];
            } else {
                return null;
            }
        }

        public Famille Marier(Personne nouveauConjoint)
        {
            // Quelques verification:  je ne me marie pas a moi meme, je ne suis pas deja marie, et j'ai un
            // vrai conjoint non null.
            if (nouveauConjoint == this || nouveauConjoint == null || nouveauConjoint.conjoint != null )
            {
                throw new ArgumentException("Beurk...");
            }

            conjoint = nouveauConjoint;
            nouveauConjoint.conjoint = this;

            // generer famille


            return null;
        }

        public override String ToString()
        {
            return name + " (" + age + ") " + (conjoint != null);
        }
    }
}