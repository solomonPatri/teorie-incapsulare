using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieIncapsulare.models
{
    public class Telefon
    {
        public string utilizator;
        public string marca;
        public string model;
        public int anul;
        public string probTehn;

        public string DescriereTelf()
        {
            string des = " ";
            des += "Utilizator: " +utilizator + "\n";
            des += "Marca: " + marca + "\n";
            des += "Modelul: " + model + "\n";
            des += "Anul: " + anul + "\n";
            des += "Probleme tehnice: " + probTehn + "\n";

            return des;
        }



    }
}
