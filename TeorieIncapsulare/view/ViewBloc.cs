using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare.models;
using TeorieIncapsulare.service;

namespace TeorieIncapsulare.view
{
    internal class ViewBloc
    {
        public ServiceBloc serviceblocul = new ServiceBloc();

        public void meniu()
        {
            Console.WriteLine("1-> Apartamentele din bloc:  " + "\n");
            Console.WriteLine("2-> Apartamentele care traiesc perechi de persone:  " + "\n");
            Console.WriteLine("3-> Introduceti Chirie/Propietar: " + "\n");
            Console.WriteLine("4-> Totalul de persoane in bloc: " + "\n");
            Console.WriteLine("5-> Introduceti propietar pentru eliminare: " + "\n");
           

        }
        public void play()
        {
            this.serviceblocul.load();
            bool run = true;
            while (run)
            {
                meniu();
                int adaugare = int.Parse(Console.ReadLine());
                switch (adaugare)
                {
                    case 1:
                        this.serviceblocul.afisare();
                        break;
                    case 2:
                        this.serviceblocul.Perechipare();
                        break;
                    case 3:
                        Locuinta_();
                        break;

                    case 4:
                       afisareTotal();
                        break;
                    case 5:
                        stergereapartament();
                        break;
                }
            }


        }

        public void Locuinta_()
        {
            string locuinta = Console.ReadLine();
            Blocul ap = serviceblocul.Locuinta(locuinta);
            if (ap == null)
            {
                Console.WriteLine("Nu locuieste nimeni: ");

            }

        }

        public void afisareTotal()
        {
            Console.WriteLine("Numarul de persoane care locuiesc in bloc sunt: ");
            serviceblocul.Total();

        }

        public void stergereapartament()
        {
            Console.WriteLine("Introduceti Chirie/Propietar: ");
            string locuinta = Console.ReadLine();
            serviceblocul.stergere(locuinta);
            serviceblocul.afisare();


        }





    }
}