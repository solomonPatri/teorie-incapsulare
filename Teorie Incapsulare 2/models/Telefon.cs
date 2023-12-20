using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_Incapsulare_2.models
{
    public class Telefon
    {
    
        private string _propietar; 
        private string _marca;
        private int _an;
        private int _memorie;

        public Telefon(string propietar, string marca, int an,int memorie)
        {
            _propietar = propietar;
            _marca = marca;
            _an = an;
            _memorie = memorie;
          

        }





        public Telefon()
        {



            Console.WriteLine("Eu sunt constructorul fara parametri");
        }



        public Telefon(string mesaj)
        {


            Console.WriteLine(mesaj);
        }

        public Telefon(string marcaValue, int anValue)
        {

            this._an = anValue;
            this._marca = marcaValue;


            Console.WriteLine("Sunt in constructorul cu 2 paramterii");
        }


        public string Propietar
        {
            get { return _propietar; }

            set { _propietar = value; }
        }
        public string Marca
        {
            get { return _marca; }

            set { _marca = value; }
        }
        public int An
        {
            get { return _an; }

            set { _an = value; }
        }
        public int Memorie
        {
            get { return _memorie; }

            set { _memorie = value; }
        }






        public string DescriereTelefon()
        {
            string desc = " ";
            desc += "Propietar: " + _propietar + "\n";
            desc += "Model: " + _marca + "\n";
            desc += "An: " + _an + "\n";
            desc += "Culoare: " + _memorie + "\n";

            return desc;



        }





    }
}