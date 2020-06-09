using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class IiTPStudent : StudentBSUIR
    {
        private bool _isFitu;

        public IiTPStudent() : base()
        {
            StudentNumber = "*5350***";
            GroupNumber = "*5350*";
            Faculty = BsuirFaculty.FKSiS;
            Specialty = "IiTP";
        }

        public IiTPStudent(string name, string surname) : base(name, surname)
        {
            StudentNumber = "*5350***";
            GroupNumber = "*5350*";
            Faculty = BsuirFaculty.FKSiS;
            Specialty = "IiTP";
        }

        public IiTPStudent(string name, string surname, string nationality, Gender gender, int day, int month, int year) :
            base(name, surname, nationality, gender, day, month, year)
        {
            StudentNumber = "*5350***";
            GroupNumber = "*5350*";
            Faculty = BsuirFaculty.FKSiS;
            Specialty = "IiTP";
        }

        public IiTPStudent(string name, string surname, string nationality, Gender gender, int day, int month, int year,
            BsuirFaculty faculty, string specialty, StudentStatus status, string curator, string groupNumber, string studentNumber,
            ushort language, ushort mathematic, ushort physics, ushort sertificate, ushort yearOfEntering, ushort grade,
            bool isWinnerOlympiad, bool isSetteled, bool isBuget)
            : base(name, surname, nationality, gender, day, month, year, faculty, specialty, status, curator, groupNumber, studentNumber,
            language, mathematic, physics, sertificate, yearOfEntering, grade, isWinnerOlympiad, isSetteled, isBuget)
        {
            if (faculty != BsuirFaculty.FKSiS || specialty != "IiTP")
            {
                Console.WriteLine("Неверная специальность или факультет");
                Faculty = BsuirFaculty.FKSiS;
                Specialty = "IiTP";
            }
        }

        public sealed override void Death(int dayOfDeath, int monthOfDeath, int yearOfDeath)
        {
            base.Death(dayOfDeath, monthOfDeath, yearOfDeath);
            Console.WriteLine("Все мы уже давно мерты внутри. Он(а) не был исключением, он(а) был(а) одним из нас");
        }

        public sealed override void CheckStudentData()
        {
            if (!_isFitu)
            {
                base.CheckStudentData();
                if (Faculty != BsuirFaculty.FKSiS)
                    Console.WriteLine("Не тот факультет");
                if (Specialty != "IiTP")
                    Console.WriteLine("");
                for (int i = 1; i < 5; i++)
                {
                    const string check = "5350";
                    if (GroupNumber[i] != check[i - 1])
                    {
                        Console.WriteLine("Неправильный номер группы");
                        break;
                    }
                }

                if (StudentNumber != null)
                    for (int i = 1; i < 5; i++)
                    {
                        const string check = "5350";
                        if (StudentNumber[i] != check[i - 1])
                        {
                            Console.WriteLine("Неправильный номер студенческого");
                            break;
                        }
                    }
            }
            else
                if (Faculty != BsuirFaculty.FITU)
                Console.WriteLine("Не тот факультет");
        }

        public void GoToFity()
        {
            Console.WriteLine("Береж или Волорова?");
            Faculty = BsuirFaculty.FITU;
            _isFitu = true;
        }
    }
}
