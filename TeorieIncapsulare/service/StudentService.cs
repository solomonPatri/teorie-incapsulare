using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare.models;

namespace TeorieIncapsulare.service
{
    public class StudentService
    {
        public List<Student> students = new List<Student>();


        public void load()
        {
            Student a1 = new Student();
            a1.nume = "Mario";
            a1.varsta = 19;
            a1.anstudiu = 2;
            a1.medie = 7;

            Student a2 = new Student();
            a2.nume = "Alex";
            a2.varsta = 22;
            a2.anstudiu = 3;
            a2.medie = 3;

            Student a3 = new Student();
            a3.nume = "Maria";
            a3.varsta = 21;
            a3.anstudiu = 1;
            a3.medie = 10;


            students.Add(a1);
            students.Add(a2);
            students.Add(a3);


        }


        //todo functie de afisare studenti
        public void afisare()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].DescriereStudent());

            }
        }
        public void parcurgere()
        {
            for(int i=0;i<students.Count;i++)
            {

            }


        }
        //todo functie ce adauga un student

        public void addStudent(Student student)
        {
          
            this.students.Add(student); 


        }
        
        //functie ce primeste ca parametru numele studentului si studentul
        public Student findStudentByName(string student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].nume.Equals(student))
                {
                    return students[i];

                }
            }

            return null;
        }
        public void studentPremiat()
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].medie == 10)
                {
                    Console.WriteLine("Studentul promovat este: " +"\n"+ students[i].DescriereStudent());
                }


            }
  
        }

        public void studentsNepromo()
        {
            for(int i=0; i < students.Count; ++i)
            {
                Console.WriteLine("Studentii nepromovati sunt: " + "\n" + students[i].DescriereStudent());
            }


        }

        public double mediastud()
        {
            int suma=0;
     
            for(int i=0; i < students.Count; i++) {

                suma += students[i].medie;
               
            }
            return suma / students.Count;
        }

    }
}
