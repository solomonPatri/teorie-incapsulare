using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare.models;

namespace TeorieIncapsulare.service
{
    public class ServiceTelf
    {
        public List<Telefon> telefon = new List<Telefon>();

        public void load()
        {
            Telefon t1 = new Telefon();
            t1.utilizator = "Patricia";
            t1.marca = "Samsung";
            t1.model = "A51";
            t1.anul = 2010;
            t1.probTehn = "Defect";

            Telefon t2 = new Telefon();
            t2.utilizator = "Mario";
            t2.marca = "Iphone";
            t2.model = "11";
            t2.anul = 2016;
            t2.probTehn = "Functionabil";

            Telefon t3 = new Telefon();
            t3.utilizator = "Silviu";
            t3.marca = "Iphone";
            t3.model = "13";
            t3.anul = 2019;
            t3.probTehn = "Functionabil";

            Telefon t4 = new Telefon();
            t4.utilizator = "Mihaela";
            t4.marca = "Samsung";
            t4.model = "S20";
            t4.anul = 2021;
            t4.probTehn = "Functionabil";

            Telefon t5 = new Telefon();
            t5.utilizator = "Ana";
            t5.marca = "Iphone";
            t5.model = "14";
            t5.anul = 2023;
            t5.probTehn = "Defect";


            this.telefon.Add(t1);
            this.telefon.Add(t2);
            this.telefon.Add(t3);
            this.telefon.Add(t4);
            this.telefon.Add(t5);

        }

        public void afisare()
        {
            for (int i = 0; i < this.telefon.Count; i++)
            {
                Console.Write(telefon[i].DescriereTelf());

            }

        }

        public void sortareTelefonTip()
        {
            for (int i = 0; i < this.telefon.Count; i++)
            {
                if (telefon[i].marca.CompareTo("Samsung") > 0)
                {
                    Console.WriteLine(telefon[i].DescriereTelf());

                }
            }

        } //case  1 nu merge


        public void sortareTelefonAn()
        {
            for (int i = 0; i < this.telefon.Count; i++)
            {
                if (telefon[i].anul >= 2016 && telefon[i].anul <= 2023)
                {

                    Console.WriteLine(" * " + telefon[i].DescriereTelf() + "\n");

                }
                else
                {
                    Console.WriteLine("Nu exista telefon intre (2016-2023)");
                }
            }


        }

        public void ElimiTelefon(string utilizator)
        {
            for (int i = 0; i < telefon.Count; i++)
            {
                if (telefon[i].utilizator.CompareTo(utilizator) > 0)
                {
                    telefon.RemoveAt(i);

                }
            }

        }

        public void sortarealfabetic()
        {
            for (int i = 0; i < telefon.Count - 1; i++)
            {
                for (int j = i++; j < telefon.Count; j++)
                {
                    if (telefon[i].utilizator.CompareTo(telefon[j].utilizator) > 0)
                    {
                        Telefon aux = telefon[i];
                        telefon[i] = telefon[j];
                        telefon[j] = aux;
                    }


                }
            }

        }

        public void afisareUtilizator()
        {
            for (int i = 0; i < telefon.Count; i++)
            {
                Console.WriteLine(telefon[i].utilizator + "\n");
            }
        }

        public void OfertaTelefon()
        {
            for (int i = 0; i < telefon.Count; i++)
            {
                if (telefon[i].probTehn.CompareTo("Functionabil") > 0)
                {

                    Console.WriteLine(telefon[i].DescriereTelf() + "\n");

                }



            }



        }





    }
}


