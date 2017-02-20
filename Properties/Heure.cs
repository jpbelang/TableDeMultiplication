namespace Properties
{
    public class Heure
    {
        public int heure { get; set; }
        public int minute { get; set; }
        public int second { get; }

        public Heure(int heure, int minute, int second)
        {
            this.heure = heure;
            this.minute = minute;
            this.second = second;
        }
    }
}