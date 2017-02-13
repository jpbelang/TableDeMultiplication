namespace Formes
{
    public interface Canevas
    {
        /*
            Ajoute une forme au canevas.  Si la forme deborde du canevas, une exception
            IllegalArgument peut etre lancee.
        */
        void AjouterForme(Forme forme);

        /*
            Surface totale couverte
        */
        double CalculeSurfaceCouverte();

    }
}