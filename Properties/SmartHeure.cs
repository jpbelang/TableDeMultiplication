using System;

namespace Properties
{
    public class SmartHeure
    {

        private int heure;
        private int minute;
        private int seconde;

        public int Heure
        {
            get { return heure; }
            set
            {
                if (value > 12)
                {
                    throw new ArgumentException("heure invalide: " + value);
                }
                heure = value;
            }
        }

        public int Minute
        {
            get { return minute;  }
            set
            {
                if (value > 59)
                {
                    throw new ArgumentException("minute invalide: " + value);
                }
                minute = value;
            }
        }

        public int Second { get { return seconde; } }

        public SmartHeure(int heure, int minute, int seconde)
        {
            this.heure = heure;
            this.minute = minute;
            this.seconde = seconde;
        }

    }
}