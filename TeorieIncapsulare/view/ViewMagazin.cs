using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare.models;
using TeorieIncapsulare.service;

namespace TeorieIncapsulare.view
{
    internal class ViewMagazin
    {
        public ServiceMagazin servicemagazin = new ServiceMagazin();


        public void meniu()
        {
            Console.WriteLine("1-> Magazinele sunt: " + "\n");
            Console.WriteLine("2-> Magazinul cu cei mai multi angajati" + "\n");
            Console.WriteLine("3-> Doriti sa se deschida un magazin:  " + "\n");
            Console.WriteLine("4-> Doriti sa stergeti un magazin " + "\n");



        }
        public void play()
        {
            this.servicemagazin.load();
            bool run = true;
            while (run)
            {
                meniu();

                int adaugare = int.Parse(Console.ReadLine());

                switch (adaugare)
                {

                    case 1:
                        this.servicemagazin.afisare();
                        break;
                    case 2:
                        this.servicemagazin.sortareCapacitate();
                        break;
                    case 3:
                        adaugareMagazin();
                        break;
                    case 4:
                        this.servicemagazin.EliminareMagazin();
                        break;

                    default:
                        Console.WriteLine("Algere gresita: ");
                        break;



                }

            }



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

            int salariul = int.Parse(Console.ReadLine());



            Magazin market = new Magazin();

            market.magazin = magazin;
            market.oras = oras;
            market.nrangajat = nrangajati;
            market.salariul = salariul;

            servicemagazin.AddMagazin(market);



        }

    }
}

    

