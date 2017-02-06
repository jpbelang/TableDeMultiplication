using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Xsl.Runtime;

namespace ListsAndMaps
{
    class Fichier
    {
        private string nom;
        private List<string> contenu = new List<string>();

        public Fichier(string nom)
        {
            this.nom = nom;
        }


        public void AjouterContenu(string contenu)
        {
            this.contenu.Add(contenu);
        }

        public void Cat()
        {
            foreach (var ligne in contenu)
            {
                Console.WriteLine(nom + ": " + ligne);
            }
        }

        public override string ToString()
        {
            return "taille " + contenu.Count;
        }
    }

    class Repertoire
    {
        private Dictionary<string, Fichier> fichiers = new Dictionary<string, Fichier>();

        public Repertoire()
        {
        }

        public Fichier NouveauFichier(string nom)
        {
            Fichier f = new Fichier(nom);
            fichiers.Add(nom, f);

            return f;
        }

        public void ListerRepertoire()
        {
            foreach (var nomFichier in fichiers.Keys)
            {
                Console.WriteLine(nomFichier + " " + fichiers[nomFichier]);
            }
        }

        public static void Main(string[] args)
        {

            Repertoire r = new Repertoire();
            Fichier f = r.NouveauFichier("foo");
            Fichier f1 = r.NouveauFichier("goo");
            Fichier f2 = r.NouveauFichier("fjkfoo");
            Fichier f3 = r.NouveauFichier("flkjgldfg");
            Fichier f4 = r.NouveauFichier("fsfkdfh");

            f.AjouterContenu("Moomoo");
            f.AjouterContenu("googoo");

            //f.Cat();
            r.ListerRepertoire();
        }
    }
}