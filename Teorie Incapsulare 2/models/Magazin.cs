
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieIncapsulare2.models
{
    public class Magazin
    {
        public string _magazin;
        public int _andesch;
        public int _nrangajati;
        public string _oras;



        public string Magazine
        {
            get { return _magazin; }

            set { _magazin = value; }

        }

        public int AnulDeschidere
        {
            get { return _andesch; }
            set { _andesch = value; }
        }

        public int NrAngajati
        {

            get { return _nrangajati; }
            set { _nrangajati = value; }
        }
        public string Oras
        {
            get { return _oras; }
            set { _oras = value; }
        }

        public string DescriereMagazin()
        {
            string desc = " ";
            desc += "Magazinul : " + _magazin + "\n";
            desc += "Anul deschideri: " + _andesch + "\n";
            desc += "Numarul de angajati: " + _nrangajati + "\n";
            desc += "Orasul: " + _oras + "\n";
            return desc;

        }



        public Magazin(string magazin)
        {

            Console.WriteLine(magazin);
        }
        public Magazin()
        {

            Console.WriteLine("Nu este niciun Magazin prin localitate.");


        }

        public Magazin (string magazin,int an,int nrang,string oras)
        {
            _magazin = magazin;
            _andesch = an;
            _nrangajati = nrang;
            _oras = oras;

        }





    }

}





