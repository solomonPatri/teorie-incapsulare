using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieIncapsulare.models
{
    public class Blocul
    {
        public int apart;
        public int pers;
        public string locuinta;
        public string DescriereBloc()
        {
            string des = " ";
            des += "Apartamentul: " + apart + "\n";
            des += "Locuitor: : " + pers + "\n";
            des += "Chirie/propietar: " + locuinta + "\n";

            return des;
        }



    }
}