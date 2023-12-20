using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare2.models;
using TeorieIncapsulare2.service;
using Teorie_Incapsulare_2.models;
using Teorie_Incapsulare_2.service;

namespace Teorie_Incapsulare_2.view
{
    internal class ViewMagazin
    {
        private ServiceMagazin _servicemagazin;

        public ViewMagazin()
        {

            _servicemagazin = new ServiceMagazin();
            play();
        }


        public void meniu()
        {
            Console.WriteLine("1-> Magazinele sunt: " + "\n");
            Console.WriteLine("2-> Magazinul cu cei mai multi angajati" + "\n");
            Console.WriteLine("3-> Doriti sa se deschida un magazin:  " + "\n");
            Console.WriteLine("4-> Doriti sa stergeti un magazin " + "\n");
            Console.WriteLine("5-> Salariul cel mai mic: ");



        }
        public void play()
        {
            this._servicemagazin.load();
            bool run = true;
            while (run)
            {
                meniu();

                int adaugare = int.Parse(Console.ReadLine());

                switch (adaugare)
                {

                    case 1:
                        this._servicemagazin.afisare();
                        break;
                    case 2:
                        this._servicemagazin.sortareCapacitate();
                        break;
                    case 3:
                        adaugareMagazin();
                        break;
                    case 4:
                        StergereaMagazin();
                        break;

                    default:
                        Console.WriteLine("Algere gresita: ");
                        break;



                }

            }



        }

        public void afisare()
        {
            _servicemagazin.afisare();
        }
        public void adaugareMagazin()
        {

            Console.WriteLine("Introduceti Magazinul: ");


            string magazin = Console.ReadLine();

            Console.WriteLine("Introduceti Orasul unde doriti sal deschideti: ");


            string oras = Console.ReadLine();

            Console.WriteLine("Introduceti capacitatea de lucratori: ");

            int nrangajati = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti salariul pe care il oferiti: ");

            int andeschidere = int.Parse(Console.ReadLine());



            Magazin market = new Magazin();

            market.Magazine = magazin;
            market.Oras = oras;
            market.NrAngajati = nrangajati;
            market.AnulDeschidere = andeschidere;

            _servicemagazin.AddMagazin(market);



        }

        public void StergereaMagazin()
        {
            Console.WriteLine("Introduceti numele magazinului: ");

            string nume = Console.ReadLine();

            _servicemagazin.EliminareMagazin(nume);

            Console.WriteLine("Magazinele ramase sunt: ");
            _servicemagazin.afisare();

        }
    }
}
