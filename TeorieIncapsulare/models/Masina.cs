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
        private string _marca;
        private string _model;
        private int _an;
        private string _culoare;

        //accesori

        public string Marca
        {

            get { return _marca; }
            set { _marca = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int An
        {
            get { return _an; }
            set { _an = value; }
        }
        public string Culoare
        {
            get { return _culoare; }
            set { _culoare = value; }

        }



        //Constructorii

        public Masina()
        {
            Console.WriteLine("Masina nu este disponibila.");


        }
       
        
        public Masina(string marca,string model ,int an,string culoare)
        {

            _marca = marca; 
            _model = model;
            _an = an;
            _culoare = culoare;

        }

        //metode/functii

        public string DescriereMasina()
        {
            string desc = "";

            desc += "Marca " + _marca + "\n";

            desc += "Model " + _model + "\n";

            desc += "Culoare " + _culoare + "\n";

            desc += "An " + _an+"\n";


            return desc;

        }

    }

}
