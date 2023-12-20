using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare2.models;
using Teorie_Incapsulare_2.models;

namespace TeorieIncapsulare2.service
{
    public class ServiceMagazin
    {
        private List<Magazin> market;


        public ServiceMagazin()
        {

            market = new List<Magazin>();
            this.load();
        }

        public void load()
        {
            Magazin m1 = new Magazin("Lidl",2023, 2455,"Sibiu");


            Magazin m2 = new Magazin("Mega-Image",2010,3560,"Alba-Iulia");
           
            Magazin m3 = new Magazin("Kaufland",2009,1238,"Bucuresti");
           
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
                if (market[i].Oras.CompareTo("Sibiu") > 0)
                {
                    Console.WriteLine(market[i].DescriereMagazin());

                }
            }
        }

        public void sortareCapacitate()
        {
            for (int i = 0; i < this.market.Count; i++)
            {
                if (market[i].NrAngajati >= 2000)
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
                if (market[i]._magazin.Equals(nume))
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
                    if (market[i]._magazin.CompareTo(market[j]._magazin) > 0)
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
