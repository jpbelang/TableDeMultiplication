using System.Collections;
using System.Collections.Generic;

namespace PersonneEtFamille
{
    public class AgeComparer: IComparer<Personne>
    {
        public int Compare(Personne x, Personne y)
        {
            return x.age - y.age;
        }
    }
}