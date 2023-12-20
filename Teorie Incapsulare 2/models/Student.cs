using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_Incapsulare_2.models
{
    public class Student
    {
        public string _nume;
        public int _anFac;
        public string _facult;
        public int _nota;


        //accesori

        public string Nume
        {
            get { return _nume; }
            set { _nume = value; }

        }
        public int AnFacultate
        {
            get { return _anFac; }
            set { _anFac = value; }

        }
        public string Facultate
        {
            get { return _facult; }
            set { _facult = value; }
        }
        public int Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public string DescriereStudent ()
        {
            string desc = " ";
            desc += "Nume: " + _nume + "\n";
            desc += "An de ffacultate: " + _anFac + "\n";
            desc += "Facultate: " + _facult + "\n";
            desc += "Nota finala: " + _nota + "\n";

            return desc;

        }

        public Student()
        {
            Console.WriteLine("Studentii sunt: ");
            Console.WriteLine(DescriereStudent());
        }
        public Student(string nume)
        {
            Console.WriteLine("Studentul: "+nume);

        }


        public Student(string nume, int an , string facultate, int nota)
        {
            _nume = nume;
            _anFac = an;
            _facult = facultate;
            _nota = nota;

        }
    }
}
