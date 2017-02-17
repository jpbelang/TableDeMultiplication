namespace Formes
{
    public class Carre :Forme
    {
        private readonly double x;
        private readonly double y;
        private readonly double size;

        public Carre(double x, double y, double size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public double Surface()
        {
            return this.size * this.size;
        }

        public bool ContientPoint(double x, double y)
        {
            if (x < this.x)
            {
                return false;
            }

            if (y < this.y)
            {
                return false;
            }

            if (x > this.x + this.size)
            {
                return false;
            }

            if (y > this.y + this.size)
            {
                return false;
            }

            return true;
        }

        public BoiteContour BoiteContour()
        {
            return new BoiteContour(this.x, this.y, this.x + size, this.y + size);
        }
    }
}