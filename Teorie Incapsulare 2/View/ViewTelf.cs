using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare2.models;
using Teorie_Incapsulare_2.service;
using Teorie_Incapsulare_2.models;
namespace TeorieIncapsulare2.view
{
    internal class ViewTelf
    {
        private ServiceTelf _servicetelefon;

        public ViewTelf()
        {
            _servicetelefon = new ServiceTelf();

            play();
        }




        public void meniu()
        {
            Console.WriteLine("1-> Doriti Android sau !OS? : " + "\n");
            Console.WriteLine("2-> Din ce An Doriti telefon (2016-2023): " + "\n");
            Console.WriteLine("3-> Numele utilizatoriilor in ordine alfabetica: " + "\n");
            Console.WriteLine("4-> Alegerea telefonului scade din optiuni: " + "\n");
            Console.WriteLine("5-> Oferta Telefonului este: " + "\n");

        }
        public void play()
        {
            this._servicetelefon.load();
            bool run = true;
            while (run)
            {
                meniu();
                int adaugare = int.Parse(Console.ReadLine());
                switch (adaugare)
                {
                    case 1:
                        afisaretelefonSistem();



                        break;
                    case 2:
                        this._servicetelefon.sortareTelefonAn();
                        break;
                    case 3:
                        afisareUtiliz();
                        break;

                    case 4:
                        EliminareaTelf();
                        break;
                    case 5:
                        this._servicetelefon.OfertaTelefon();
                        break;

                }
            }




        }

        public void afisaretelefonSistem()
        {

            Console.WriteLine("Introduceti ce doriti: " + "\n");

            string marca = Console.ReadLine();



            Console.WriteLine("Telefoanele au urmatoarele sisteme: " + "\n");

            _servicetelefon.definireSisteme(marca);


        }
        public void afisareToateTelf()
        {
            Console.WriteLine("utilizatori sunt: " + "\n");




        }
        public void EliminareaTelf()
        {
            Console.WriteLine("Introduceti datele: ");

            string utilizator = Console.ReadLine();


            Telefon telf = new Telefon();

            telf.Propietar = utilizator;

            _servicetelefon.ElimiTelefon(utilizator);

            Console.WriteLine("TELEFOANELE RAMASE: ");
            _servicetelefon.afisare();

        }

        public void afisareUtiliz()
        {
            Console.WriteLine("Utilizatori sunt: " + "\n");
            this._servicetelefon.sortarealfabetic();
            this._servicetelefon.afisareUtilizator();
        }


    }
}
