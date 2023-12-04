using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieIncapsulare.models
{
    public class Masina
    {
        //o clasa este formata din atribute si metode

        //atribute
        public string marca;
        public string model;
        public int an;
        public string culoare;


        //metode/functii

        public string DescriereMasina()
        {
            string desc = "";

            desc += "Marca " + marca + "\n";

            desc += "Model " + model + "\n";

            desc += "Culoare " + culoare + "\n";

            desc += "An " + an;


            return desc;

        }

    }

}
