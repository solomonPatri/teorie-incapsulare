using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeorieIncapsulare.models;
using TeorieIncapsulare.service;

namespace TeorieIncapsulare.view
{
    internal class ViewStudent
    {

        public StudentService studentService = new StudentService();

        public void meniu()
        {

            Console.WriteLine("1->afisati stundenti" + "\n");
            Console.WriteLine("2->adaugare stundent" + "\n");
            Console.WriteLine("3->Studentul premiat" + "\n");
            Console.WriteLine("4->Studenti Nepromovati:" + "\n");
            Console.WriteLine("5->Media Totala a studentiilor: " + "\n");
            Console.WriteLine("6 ->Stergerea student: ");


        }

        public void play()
        {



            this.studentService.load();//incarcam studenmti
            bool run = true;

            while (run)
            {

                meniu();

                int alegere = int.Parse(Console.ReadLine());


                switch (alegere)
                {
                    case 1:
                        this.studentService.afisare();
                        break;
                    case 2:

                        adaugare();

                        break;
                    case 3:
                        this.studentService.studentPremiat();
                        break;
                    case 4:
                        this.studentService.studentsNepromo();
                        break;
                    case 5:
                        Console.WriteLine(this.studentService.mediastud());
                        break;
                    case 6:
                        stergere();
                        break;

                    default: Console.WriteLine("alegere gresita");
                        break;

                }

            }
        }

        public void adaugare()
        {

            Console.WriteLine("Introduceti numele studentului");


            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti varsta studentului");


            int varsta = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti anul de studiu");

            int anStudiu = int.Parse(Console.ReadLine());


            Student student = new Student();

            student.nume = nume;
            student.varsta = varsta;
            student.anstudiu = anStudiu;



            Student cautat = studentService.findStudentByName(nume);

            if (cautat == null)
            {

                studentService.addStudent(student);

                Console.WriteLine("Studentul a fost adaugat cu succes");
            }
            else
            {

                Console.WriteLine("M-ai exsita un student cu numele dat");
            }



        }
        public void stergere()
        {
            Console.WriteLine("Introduceti numele studentului care doriti sa stergeti: ");
            string nume = Console.ReadLine();
            studentService.stergereStudent(nume);
            Console.WriteLine("Au ramas studenti: ");
            studentService.afisare();

        }




    }
}





    


