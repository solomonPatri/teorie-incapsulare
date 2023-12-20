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
    internal class ViewMasina
    {

        private ServiceMasina _serviceMasina;

       
        public ViewMasina()
        {
            _serviceMasina = new ServiceMasina();

            play();

        }

        public void meniu()
        {
            Console.WriteLine("1-> Masinele listate sunt: " + "\n");
            Console.WriteLine("2-> Masinele vechi: " + "\n");
            Console.WriteLine("3-> Doriti o masina de o culoare? " + "\n");
            Console.WriteLine("4-> Doriti sa adaugati o masina: "+"\n");
            Console.WriteLine("5-> Doriti sa stergeti o masina? "+"\n");
         


        }
        public void play()
        {
           
            bool run = true;
            while (run)
            {
                meniu();

                int adaugare = int.Parse(Console.ReadLine());

                switch (adaugare)
                {

                    case 1:
                        this._serviceMasina.Afisare();
                        break;
                    case 2:
                        this._serviceMasina.Vechime();
                        break;
                    case 3:
                        FindCarByColor();
                        break;
                    case 4:
                        AdaugareMasina();
                        break;

                    case 5:
                        StergereMasina();
                        break;
                       
                           
                    default:
                        Console.WriteLine("Algere gresita: ");
                        break;



                }

            }



        }
        public void AdaugareMasina()
        {

            Console.WriteLine("Introduceti Marca masini: ");


            string marca = Console.ReadLine();

            Console.WriteLine("Introduceti modelul masini: ");


            string model = Console.ReadLine();

            Console.WriteLine("Introduceti anul masini: ");

            int an = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti culoarea: ");

            string culoare = Console.ReadLine();



            Masina masina = new Masina();

            masina.Marca = marca;
            masina.Model = model;
            masina.An = an;
            masina.Culoare = culoare;


            Masina cautat = _serviceMasina.findCarByColor(culoare);

            if (cautat == null) { 
    

                _serviceMasina.AddMasina(masina);

                Console.WriteLine("Masina a fost adaugat cu succes");
            }else{

                Console.WriteLine("M-ai exista o masina cu acelasi caracteristici.");
            }


        }
        public void StergereMasina()
        {
            Console.WriteLine("Introduceti anul a masinei care doriti sa stergeti: ");

            int an = int.Parse(Console.ReadLine());


            Masina mas = new Masina();

            mas.An = an;

            this._serviceMasina.Stergeremasina(an);

            Console.WriteLine("Masiniile ramase dupa stergerea: ");
            _serviceMasina.Afisare();

        }

        public void FindCarByColor()
        {
            Console.WriteLine("Introduceti culoarea masini:  ");
            string culoare = Console.ReadLine();
            Masina mas = _serviceMasina.findCarByColor(culoare);
            if (mas== null)
            { 
                Console.WriteLine("Nu exista o masina cu culoarea aceasta: ");

            }
            
        } 


    }

}
