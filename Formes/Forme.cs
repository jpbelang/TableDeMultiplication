namespace Formes
{
    public interface Forme
    {
        double Surface();
        bool ContientPoint(double x, double y);

        BoiteContour BoiteContour();

    }
}