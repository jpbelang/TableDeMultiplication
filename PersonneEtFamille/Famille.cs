namespace PersonneEtFamille
{
    public class Famille
    {
        private readonly Personne personne;
        private readonly Personne conjoint;
        private int enfantsUnion;

        public Famille(Personne personne, Personne conjoint)
        {
            this.personne = personne;
            this.conjoint = conjoint;
            this.enfantsUnion = 0;
        }

        public void Naissance()
        {
            this.enfantsUnion++;
        }
        public int Taille()
        {
            return enfantsUnion;
        }

        public int TailleEtendue()
        {
            return enfantsUnion + enfantsPrecedents();
        }

        private int enfantsPrecedents()
        {
            return personne.CompteEnfants() + conjoint.CompteEnfants() - 2 * enfantsUnion;
        }
    }
}