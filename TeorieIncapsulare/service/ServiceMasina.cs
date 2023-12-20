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
        private List<Masina> _carList;


        public ServiceMasina()
        {

            _carList=new List<Masina>();
            this.Load();
        }


        



        private void Load()
        {
            Masina m1 = new Masina("Dacia", "Sandero", 2013 ,"Neagra");
            

            Masina m2 = new Masina("Seat","Toledo",2008 ,"Gri");
          
            Masina m3 = new Masina("BMW","X3",2020,"Albastra");

           

            this._carList.Add(m1);
            this._carList.Add(m2);
            this._carList.Add(m3);
        }
        public void Afisare()
        {  
            for(int i = 0; i < this._carList.Count; i++)
            {
                Console.Write(_carList[i].DescriereMasina());

            }

        }
        public void Vechime()
        { 
            for(int i = 0; i < this._carList.Count; i++)
            {
                if (_carList[i].An <= 2010)
                {
                    Console.WriteLine(_carList[i].Marca+ " anul: " + _carList[i].An+" este vechie.");
                }
                else
                {
                    Console.WriteLine(_carList[i].Marca+" "+"Masina nu este vechie.");
                }

            }


        }
        public Masina findCarByColor(string culoare){
            for(int i = 0; i <_carList.Count; i++)
            {
                if (_carList[i].Culoare.Equals(culoare)){

                Console.WriteLine("Masina se regaseste in lista si este: " + "\n");

                 Console.WriteLine(_carList[i].DescriereMasina());
                }
            }
            return null;
      
        }

        public double Sortarevechi()
        {
           int max = _carList[0].An;
            for(int i=0; i < _carList.Count; i++)
            {
                if (_carList[i].An > max)
                {
                    max = _carList[i].An;
                    
                }
               
            }
            return max;
            
        }

        public void AddMasina(Masina masina)
        {
            this._carList.Add(masina);

        }

        public void Stergeremasina(int an)
        {
            for (int i = 0; i < _carList.Count; i++)
            {
                if (_carList[i].An.CompareTo(an)>0)
                {
                    _carList.RemoveAt(i);

                }
            }

        }



    }
}
