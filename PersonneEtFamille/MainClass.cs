using System;

namespace PersonneEtFamille
{
    public class MainClass
    {

        public static void Main(string[] args)
        {
            Personne p1 = new Personne("Paul", 18);
            Personne p2 = new Personne("Paule", 18);
            Personne p3 = new Personne("Jeannette", 21);

            // Nouvelle famille.
            Famille famille = p2.Marier(p1);
            Personne david = p2.Procreer("David");
            Personne michel = p2.Procreer("Michel");
            if (famille.Taille() != 2)
            {
                throw new ApplicationException("mauvaise taille");
            }
            if (famille.TailleEtendue() != 0)
            {
                throw new ApplicationException("mauvaise taille");
            }

            // Tristesse, divorce.
            p1.Divorcer();

            // Remarriage....
            Famille nouvelleFamille = p1.Marier(p3);
            if (nouvelleFamille.Taille() != 0)
            {
                throw new ApplicationException("mauvaise taille");
            }

            if (nouvelleFamille.TailleEtendue() != 2)
            {
                throw new ApplicationException("mauvaise taille");
            }

            // Nouvel enfant, check.
            Personne caroline = p1.Procreer("Caroline");
            if (nouvelleFamille.Taille() != 1)
            {
                throw new ApplicationException("mauvaise taille");
            }

            if (nouvelleFamille.TailleEtendue() != 3)
            {
                throw new ApplicationException("mauvaise taille");
            }

            //  L'ancienne famille est maintenant plus grande aussi.
            if (famille.Taille() != 2)
            {
                throw new ApplicationException("mauvaise taille");
            }
            if (famille.TailleEtendue() != 3)
            {
                throw new ApplicationException("mauvaise taille");
            }

        }
    }
}