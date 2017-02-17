using System.Collections.Generic;

namespace Formes
{
    public class SimpleCanevas : Canevas
    {
        private readonly List<Forme> formes = new List<Forme>();

        public void AjouterForme(Forme forme)
        {
            formes.Add(forme);
        }

        public double CalculeSurfaceCouverte()
        {
            double total = 0;
            foreach (var forme in formes)
            {
                total = total + forme.Surface();
            }

            return total;
        }
    }
}