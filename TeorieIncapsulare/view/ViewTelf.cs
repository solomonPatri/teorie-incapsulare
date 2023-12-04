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
    internal class ViewTelf
    {
        public ServiceTelf servicetelefon = new ServiceTelf();

        public void  meniu()
        {
            Console.WriteLine("1-> Doriti Android sau !OS? : "+"\n");
            Console.WriteLine("2-> Din ce An Doriti telefon (2016-2023): "+"\n");
            Console.WriteLine("3-> Numele utilizatoriilor in ordine alfabetica: " + "\n");
            Console.WriteLine("4-> Alegerea telefonului scade din optiuni: " + "\n");
            Console.WriteLine("5-> Oferta Telefonului este: "+ "\n");

        }
        public void play()
        {
            this.servicetelefon.load();
            bool run = true;
            while(run)
            {
                meniu();
                 int adaugare = int.Parse(Console.ReadLine());
                switch (adaugare)
                {
                    case 1:

                        afisaretelefonSistem();
                        break;
                    case 2:
                        this.servicetelefon.sortareTelefonAn();
                        break;
                    case 3:
                        afisareUtiliz();
                        break;

                    case 4: 
                        EliminareaTelf();
                        break;
                    case 5:
                        this.servicetelefon.OfertaTelefon();
                        break;

                }
            }




        }

        public void afisaretelefonSistem()
        {

            Console.WriteLine("Introduceti ce doriti: "+"\n");

            string marca = Console.ReadLine();

            Telefon telf = new Telefon();
            telf.marca = marca;

            Console.WriteLine("Telefoanele au urmatoarele sisteme: "+"\n");

            servicetelefon.definireSisteme(marca);


        }
        public void afisareToateTelf()
        {
            Console.WriteLine("utilizatori sunt: "+"\n");




        }
        public void EliminareaTelf()
        {
            Console.WriteLine("Introduceti datele: ");

            string utilizator = Console.ReadLine();


            Telefon telf = new Telefon();

            telf.utilizator = utilizator;

            this.servicetelefon.ElimiTelefon(utilizator);

            Console.WriteLine("TELEFOANELE RAMASE: ");
            this.servicetelefon.afisare();

        }

        public void afisareUtiliz()
        {
            Console.WriteLine("Utilizatori sunt: " + "\n");
            this.servicetelefon.sortarealfabetic();
            this.servicetelefon.afisareUtilizator();
        }


    }
}
