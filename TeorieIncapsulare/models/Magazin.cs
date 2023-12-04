using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieIncapsulare.models
{
    public class Magazin
    {
        public string magazin;
        public string oras;
        public int nrangajat;
        public int salariul;

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