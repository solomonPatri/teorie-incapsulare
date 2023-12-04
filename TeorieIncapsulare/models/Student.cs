using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieIncapsulare.models
{
    public class Student
    {
        public string nume;
        public int varsta;
        public int anstudiu;
        public int medie;

        public string DescriereStudent()
        {
            string descr = " ";
            descr += "Nume: " + nume + "\n";
            descr += "Varsta: " + varsta + "\n";
            descr += "An studiu: " + anstudiu + "\n";
            descr += "Media: " + medie + "\n";
            return descr;

        }



    }


}
