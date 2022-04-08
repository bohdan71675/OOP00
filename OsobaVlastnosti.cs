using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00
{
    class OsobaVlastnosti
    {
        private string jmeno;

        //public string Jmeno
        //{
        //    get
        //    {
        //        return jmeno;
        //    }
        //    private set
        //    {
        //        jmeno = value;
        //    }
        //}

        public string Jmeno { get; /*private set;*/ }

        private string prijmeni;

        public string Prijmeni
        {
            get
            {
                return prijmeni;
            }
            set
            {
                prijmeni = value;
            }
        }


        private int vyska;
        public int Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                if (value >= 15 && value <= 300)
                {
                    vyska = value;
                }
            }
        }

        private double hmotnost;

        public double Hmotnost
        {
            get
            {
                return hmotnost;
            }
            set
            {
                if (value >= 1 && value <= 500)
                {
                    hmotnost = value;
                }
            }
        }

        public OsobaVlastnosti(string jmeno)
        {
            Jmeno = jmeno;
        }

        public OsobaVlastnosti(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public OsobaVlastnosti(string jmeno, string prijmeni, int vyska, double hmotnost)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vyska = vyska;
            Hmotnost = hmotnost;
        }
        public override string ToString()
        {
            string s = "\nJmeno: " + Jmeno
                        + "\nPrijmeni: " + Prijmeni
                        // + "\n" + CeleJmenoVelkymi()
                        + "\nVyska: " + Vyska + " cm"
                        + "\nHmotnost: " + Hmotnost + " kg";
                       // + "\nBMI: " + BMI();

            return base.ToString() + "\n" + s;
        }
    }
}
