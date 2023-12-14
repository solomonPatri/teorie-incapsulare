using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare.models;

namespace TeorieIncapsulare.service
{
    public class ServiceMagazin
    {
        public List<Magazin> market = new List<Magazin>();

        public void load()
        {
            Magazin m1 = new Magazin();
            m1.magazin = "Lidl";
            m1.oras = "Sibiu";
            m1.nrangajat = 2300;
            m1.salariul= 1460;

           Magazin m2 = new Magazin();
            m2.magazin = "Mega-Image";
            m2.oras = "Cluj-napoca";
            m2.nrangajat = 3289;
            m2.salariul = 2300;

          Magazin m3 = new Magazin();
            m3.magazin = "Kaufland";
            m3.oras = "Sibiu";
            m3.nrangajat = 338;
            m3.salariul = 1600;


            market.Add(m1);
            market.Add(m2);
            market.Add(m3);
            

        }

        public void afisare()
        {
            for (int i = 0; i < this.market.Count; i++)
            {
                Console.Write(market[i].DescriereMagazin());

            }

        }

        public void sortareorasMagazin()
        {
            for (int i = 0; i < this.market.Count; i++)
            {
                if (market[i].oras.CompareTo("Sibiu") > 0)
                {
                    Console.WriteLine(market[i].DescriereMagazin());

                }
            }

        } //case  1 nu merge


        public void sortareCapacitate()
        {
            for (int i = 0; i < this.market.Count; i++)
            {
                if (market[i].nrangajat>=2000)
                {
                    Console.WriteLine("Magazinul cel mai performant: " + "\n");
                    Console.WriteLine(" * " + market[i].DescriereMagazin() + "\n");

                }
                else
                {
                    Console.WriteLine("Magazinul nu are o capacitate buna de munca");
                }
            }


        }

        public void EliminareMagazin(string nume)
        {
            for (int i = 0; i < market.Count; i++)
            {
                if (market[i].magazin.Equals(nume))
                {
                    market.RemoveAt(i);

                }
            }

        }

        public void sortarealfabetic()
        {
            for (int i = 0; i < market.Count - 1; i++)
            {
                for (int j = i++; j < market.Count; j++)
                {
                    if (market[i].magazin.CompareTo(market[j].magazin) > 0)
                    {
                        Magazin aux = market[i];
                        market[i] = market[j];
                        market[j] = aux;
                    }


                }
            }

        }

        public void afisareMagazine()
        {
            for (int i = 0; i < market.Count; i++)
            {
                Console.WriteLine(market[i].DescriereMagazin() + "\n");
            }
        }

        public void AddMagazin(Magazin Magazin)
        {

            this.market.Add(Magazin);

        }

        




    }
}