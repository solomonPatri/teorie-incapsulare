using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare.models;

namespace TeorieIncapsulare.service
{
    public class ServiceBloc
    {
        public List<Blocul> blocul = new List<Blocul>();

        public void load()
        {
            Blocul ap1 = new Blocul();

            ap1.apart = 1;
            ap1.pers = 4;
            ap1.locuinta = "Chirie";

            Blocul ap2 = new Blocul();

            ap2.apart = 34;
            ap2.pers = 3;
            ap2.locuinta = "Propietar";

            Blocul ap3 = new Blocul();

            ap3.apart = 21;
            ap3.pers = 1;
            ap3.locuinta = "Chirie";

            this.blocul.Add(ap1);
            this.blocul.Add(ap2);
            this.blocul.Add(ap3);



        }
        public void afisare()
        {
            for (int i = 0; i < this.blocul.Count; i++)
            {
                Console.Write(blocul[i].DescriereBloc());

            }

        }
        public void Perechipare()
        {
            for (int i = 0; i < this.blocul.Count; i++)
            {
                if (blocul[i].pers % 2 == 0)
                {
                    Console.WriteLine(blocul[i].DescriereBloc());

                }


            }


        }

        public Blocul Locuinta(string locuinta)
        {
            for (int i = 0; i < blocul.Count; i++)
            {
                if (blocul[i].locuinta.CompareTo(locuinta)>0)
                {

                    Console.WriteLine("In apartamentele astea traiesc in : " + "\n");

                    Console.WriteLine(blocul[i].DescriereBloc());
                }
            }
            return null;

        }

        public void Total()
        {
           int suma=0;
            for (int i = 0; i < blocul.Count; i++)
            {
                suma += blocul[i].pers;

            }
        }

        public void stergere(string locuinta)
        {
            for (int i = 0; i < blocul.Count; i++)
            {
                if (blocul[i].locuinta.Equals(locuinta))
                {

                    blocul.RemoveAt(i);
                }


            }

                
        }






    }
}

