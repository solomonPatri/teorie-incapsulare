using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Teorie_Incapsulare_2.models;

namespace Teorie_Incapsulare_2.service
{
  public class ServiceTelf
    {
        public List<Telefon> _telefoane;

        public ServiceTelf()
        {
            _telefoane = new List<Telefon> ();
            this.load();

        }
        public void load()
        {
            Telefon t1 = new Telefon ("Mario","Samsung",2021,128);
            Telefon t2 = new Telefon("Patricia", "Iphone", 2023, 128);
            Telefon t3 = new Telefon("Ana", "Huaewi", 2010, 164);

            this._telefoane.Add (t1);
            this._telefoane.Add (t2);
           this._telefoane.Add (t3);

        }
        public void afisare()
        {
            for (int i = 0; i < this._telefoane.Count; i++)
            {
                Console.Write(_telefoane[i].DescriereTelefon());

            }

        }
        public void definireSisteme(String os)
        {
            for (int i = 0; i < this._telefoane.Count; i++)
            {
                if (os.ToLower().Equals("Android".ToLower()) && _telefoane[i].Marca.Equals("Samsung"))
                {

                    Console.WriteLine(this._telefoane[i].DescriereTelefon());

                }

                else if (os.ToLower().Equals("Ios".ToLower()) && _telefoane[i].Marca.Equals("Iphone"))
                {

                    Console.WriteLine(this._telefoane[i].DescriereTelefon());
                }

            }

        }
        public void afisareDupaMarca(String marca)
        {

            for (int i = 0; i < this._telefoane.Count; i++)
            {
                if (_telefoane[i].Marca.Equals(marca))
                {
                    Console.WriteLine(_telefoane[i].DescriereTelefon());

                }

            }

        }


        public void sortareTelefonAn()
        {
            for (int i = 0; i < this._telefoane.Count; i++)
            {
                if (_telefoane[i].An >= 2016 && _telefoane[i].An <= 2023)
                {

                    Console.WriteLine(" * " + _telefoane[i].DescriereTelefon() + "\n");

                }
                else
                {
                    Console.WriteLine("Nu exista telefon intre (2016-2023)");
                }
            }


        }

        public void ElimiTelefon(string utilizator)
        {
            for (int i = 0; i < _telefoane.Count; i++)
            {
                if ( _telefoane[i].Propietar.Equals(utilizator))
                {
                    _telefoane.RemoveAt(i);

                }
            }

        }

        public void sortarealfabetic()
        {
            for (int i = 0; i < _telefoane.Count - 1; i++)
            {
                for (int j = i++; j < _telefoane.Count; j++)
                {
                    if (_telefoane[i].Propietar.CompareTo(_telefoane[j].Propietar) > 0)
                    {
                        Telefon aux = _telefoane[i];
                        _telefoane[i] = _telefoane [j];
                        _telefoane[j] = aux;
                    }


                }
            }

        }

        public void afisareUtilizator()
        {
            for (int i = 0; i <_telefoane.Count; i++)
            {
                Console.WriteLine(_telefoane[i].Propietar + "\n");
            }
        }

        public void OfertaTelefon()
        {
            for (int i = 0; i < _telefoane.Count; i++)
            {
                if (_telefoane[i].Memorie.Equals(128))
                {

                    Console.WriteLine(_telefoane[i].DescriereTelefon() + "\n");

                }



            }



        }





    }
}
