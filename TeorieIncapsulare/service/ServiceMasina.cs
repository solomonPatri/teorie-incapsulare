using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare.models;


namespace TeorieIncapsulare.service
{
    public class ServiceMasina
    {
        public List<Masina> car = new List<Masina>();

        public void load()
        {
            Masina m1 = new Masina();
            m1.marca = "Dacia";
            m1.model = "Sandero";
            m1.an = 2013;
            m1.culoare = "Neagra";

            Masina m2 = new Masina();
            m2.marca = "Seat";
            m2.model = "Toledo";
            m2.an = 2008;
            m2.culoare = "Gri";

            Masina m3 = new Masina();

            m3.marca = "BMW";
            m3.model = "X3";
            m3.an = 2020;
            m3.culoare = "Albastra";

            this.car.Add(m1);
            this.car.Add(m2);
            this.car.Add(m3);
        }
        public void afisare()
        {  
            for(int i = 0; i < this.car.Count; i++)
            {
                Console.Write(car[i].DescriereMasina());

            }

        }
        public void Vechime()
        { 
            for(int i = 0; i < this.car.Count; i++)
            {
                if (car[i].an <= 2010)
                {
                    Console.WriteLine(car[i].marca+ " anul: " + car[i].an+" este vechie.");
                }
                else
                {
                    Console.WriteLine(car[i].marca+" "+"Masina nu este vechie.");
                }

            }


        }
        public Masina findCarByColor(string culoare){
            for(int i = 0; i < car.Count; i++)
            {
                if (car[i].culoare.Equals(culoare)){

                Console.WriteLine("Masina se regaseste in lista si este: " + "\n");

                 Console.WriteLine(car[i].DescriereMasina());
                }
            }
            return null;
      
        }

        public double sortarevechi()
        {
           int max = car[0].an;
            for(int i=0; i < car.Count; i++)
            {
                if (car[i].an > max)
                {
                    max = car[i].an;
                    
                }
               
            }
            return max;
            
        }

        public void AddMasina(Masina masina)
        {
            this.car.Add(masina);

        }

        public void stergeremasina(int an)
        {
            for (int i = 0; i < car.Count; i++)
            {
                if (car[i].an.CompareTo(an)>0)
                {
                    car.RemoveAt(i);

                }
            }

        }



    }
}
