using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ASOIStudent : StudentBSUIR
    {
        public enum AllocationASOI
        {
            Интеграл,
            Тестировщик,
            Жд
        }

        public ASOIStudent() : base()
        {
            Console.WriteLine("Асои - топ спецуха(за свои деньги) \nНа ксисе нет ни сетей, ни системотехники\n");
            Faculty = BsuirFaculty.FITU;
            Specialty = "ASOI";
        }
        public ASOIStudent(string name, string surname) : base(name, surname)
        {
            Console.WriteLine("Асои - топ спецуха(за свои деньги) \nНа ксисе нет ни сетей, ни системотехники\n");
            Faculty = BsuirFaculty.FITU;
            Specialty = "ASOI";
        }

        public ASOIStudent(string name, string surname, string nationality, Gender gender, int day, int month, int year) :
            base(name, surname, nationality, gender, day, month, year)
        {
            Console.WriteLine("Асои - топ спецуха(за свои деньги) \nНа ксисе нет ни сетей, ни системотехники\n");
            Faculty = BsuirFaculty.FITU;
            Specialty = "ASOI";
        }

        public ASOIStudent(string name, string surname, string nationality, Gender gender, int day, int month, int year,
            BsuirFaculty faculty, string specialty, StudentStatus status, string curator, string groupNumber, string studentNumber,
            ushort language, ushort mathematic, ushort physics, ushort sertificate, ushort yearOfEntering, ushort grade,
            bool isWinnerOlympiad, bool isSetteled, bool isBuget)
            : base(name, surname, nationality, gender, day, month, year, faculty, specialty, status, curator, groupNumber, studentNumber,
            language, mathematic, physics, sertificate, yearOfEntering, grade, isWinnerOlympiad, isSetteled, isBuget)
        {
            Console.WriteLine("ии - топ спецуха \nНа ксисе нет ни сетей, ни системотехники\n");
            if (faculty != BsuirFaculty.FITU || specialty != "II")
            {
                Console.WriteLine("Неверная специальность или факультет");
                Faculty = BsuirFaculty.FITU;
                Specialty = "II";
            }
        }

        public sealed override void Death(int dayOfDeath, int monthOfDeath, int yearOfDeath)
        {
            Console.WriteLine("Интеграл лишился перспективного работника\n");
            base.Death(dayOfDeath, monthOfDeath, yearOfDeath);
        }

        public sealed override void CheckStudentData()
        {
            base.CheckStudentData();
            if (Faculty != BsuirFaculty.FITU || Specialty != "ASOI")
            {
                Console.WriteLine("Неверная специальность или факультет");
                Faculty = BsuirFaculty.FITU;
                Specialty = "ASOI";
            }
            if (Allocation != AllocationASOI.Интеграл.ToString() || Allocation != AllocationASOI.Тестировщик.ToString())
            {
                Console.WriteLine("Неверное распределение у студента");
            }
        }

        public sealed override void SetExpelled()
        {
            Console.WriteLine("Вы уверены, что с фиту отчисляют?");
            base.SetExpelled();
        }
    }
}
