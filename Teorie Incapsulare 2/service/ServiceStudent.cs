using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorie_Incapsulare_2.models;
using TeorieIncapsulare2.models;

namespace Teorie_Incapsulare_2.service
{
    public class ServiceStudent
    {
        private  List<Student> _students;

        public ServiceStudent()
        {
            _students = new List<Student>();
            this.load();

        }


        public void load()
        {
            Student a1 = new Student("Mario",2,"Stiinte",3);
            

            Student a2 = new Student("Ana",1,"Sport",9);
           

            Student a3 = new Student("Matei",3,"Medicina",10);
           
            _students.Add(a1);
            _students.Add(a2);
            _students.Add(a3);


        }


      
        public void afisare()
        {
            for (int i = 0; i < _students.Count; i++)
            {
                Console.WriteLine(_students[i].DescriereStudent());

            }
        }
        public void parcurgere()
        {
            for (int i = 0; i < _students.Count; i++)
            {

            }


        }
       

        public void addStudent(Student student)
        {

            this._students.Add(student);


        }

       
        public Student findStudentByName(string student)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Nume.Equals(student))
                {
                    return _students[i];

                }
            }

            return null;
        }
        public void studentPremiat()
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Nota == 10)
                {
                    Console.WriteLine("Studentul promovat este: " + "\n" +_students[i].DescriereStudent());
                }


            }

        }

        public void studentsNepromo()
        {
            for (int i = 0; i < _students.Count; ++i)
            {
                Console.WriteLine("Studentii nepromovati sunt: " + "\n" + _students[i].DescriereStudent());
            }


        }

        public double mediastud()
        {
            int suma = 0;

            for (int i = 0; i < _students.Count; i++)
            {

                suma += _students[i].Nota;

            }
            return suma / _students.Count;
        }

        public void stergereStudent(String name)
        {

            Student student = findStudentByName(name);

            _students.Remove(student);


        }

    }
}
