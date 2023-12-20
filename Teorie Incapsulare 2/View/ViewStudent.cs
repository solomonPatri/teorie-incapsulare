using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorie_Incapsulare_2.models;
using TeorieIncapsulare2.models;
using Teorie_Incapsulare_2.service;
using TeorieIncapsulare2.service;

namespace Teorie_Incapsulare_2.view
{
    internal class ViewStudent
    {

        private ServiceStudent _studentService;
            
        public ViewStudent()
        {
            _studentService = new ServiceStudent();
            play();
        }

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

            this._studentService.load();
            bool run = true;

            while (run)
            {

                meniu();

                int alegere = int.Parse(Console.ReadLine());


                switch (alegere)
                {
                    case 1:
                        this._studentService.afisare();
                        break;
                    case 2:

                        adaugare();

                        break;
                    case 3:
                        this._studentService.studentPremiat();
                        break;
                    case 4:
                        this._studentService.studentsNepromo();
                        break;
                    case 5:
                        Console.WriteLine(this._studentService.mediastud());
                        break;
                    case 6:
                        stergere();
                        break;

                    default:
                        Console.WriteLine("alegere gresita");
                        break;

                }
                 
            }
        }
        public void afisare()
        {
            _studentService.afisare();
        }

        public void adaugare()
        {

            Console.WriteLine("Introduceti numele studentului");


            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti Facultatea studentului");


           string facultate = Console.ReadLine();

            Console.WriteLine("Introduceti anul de studiu");

            int anStudiu = int.Parse(Console.ReadLine());


            Student student = new Student();

            student.Nume = nume;
            student.Facultate= facultate;
            student.AnFacultate = anStudiu;



            Student cautat =_studentService.findStudentByName(nume);

            if (cautat == null)
            {

                _studentService.addStudent(student);

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
            _studentService.stergereStudent(nume);
            Console.WriteLine("Au ramas studenti: ");
            _studentService.afisare();

        }




    }
}
