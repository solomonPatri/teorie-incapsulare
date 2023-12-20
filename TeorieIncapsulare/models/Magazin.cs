using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieIncapsulare.models
{
    public class Magazin
    {
        private string _magazin;
        private string _oras;
        private int _nrangajat;
        private int _salariul;


        public string Magazin
        {
            get { return _magazin; }
            set { _magazin = value; }

        }
        public string Oras
        {
            get { return _oras; }
            set { _oras = value; }
        }
        public int NrANgajati
        {
            get { return _nrangajat; }
            set { _nrangajat = value; }
        }
        public int Salariul
        {
            get { return _salariul; }
            set { _salariul = value; }
        }





        public string DescriereMagazin()
        {
            string des = " ";
            des += "Magazin: " + magazin + "\n";
            des += "Orasul: : " + oras + "\n";
            des += "Numarul de angajati: " + nrangajat + "\n";
            des += "Salariul: " + salariul + "\n";

            return des;
        }



    }
}