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


        public void Marier(Personne p)
        {
            if (p == this || p == null || p.conjoint != null )
            {
                throw new ArgumentException("Beurk...");
            }

            conjoint = p;
            p.conjoint = this;
        }

        public static void Main(string[] args)
        {
            Personne p1 = new Personne("Paul", 18);
            Personne p2 = new Personne("Paul", 18);

            p2.Marier(p1);
            Console.WriteLine(p1);
        }
    }
}