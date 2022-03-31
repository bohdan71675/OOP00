using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00
{
    class Osoba
    {
        private string jmeno;
        private string prijmeni;
        private int vyska;
        private double hmotnost;

        public Osoba(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public Osoba(string jmeno, string prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
        }

        public Osoba(string jmeno, string prijmeni, int vyska, double hmotnost)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vyska = vyska;
            this.hmotnost = hmotnost;
        }

        public string GetJmeno()
        {
            return jmeno;
        }

        //set jmeno nedovolime
        public string GetPrijmeni()
        {
            return prijmeni;
        }

        public void SetPrijmeni(string prijmeni)
        {
            this.prijmeni = prijmeni;
        }

        public string CeleJmenoVelkymi()
        {
            string cjv = jmeno.ToUpper() + prijmeni.ToUpper();
            return cjv;
        }
        public int GetVyska()
        {
            return vyska;
        }

        public void SetVyska(int vyska)
        {
            this.vyska = vyska;
        }
        public double GetHmotnost()
        {
            return hmotnost;
        }

        public void SetHmotost(double hmotnost)
        {
            this.hmotnost = hmotnost;
        }


        public override string ToString()
        {
            string s = "\nJmeno: " + jmeno
                        + "\nPrijmeni: " + prijmeni
                        + "\n" + CeleJmenoVelkymi()
                        + "\nVyska: " + vyska
                        + "\nHmotnost: " + hmotnost;

            return base.ToString() + "\n" + s;
        }
    }
}
