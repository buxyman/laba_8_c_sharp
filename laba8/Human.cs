using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Human
    {

        public enum Gender
        {
            male,
            female,
            indefined
        }

        protected DateTime _dateOfDeath, _dateOfBirth;
        protected TimeSpan _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public int Id { get; }
        public Gender Sex { get; set; }
        protected bool _isLife;
        protected static int id = 0;

        public Human()
        {
            Id = id;
            id++;
            Sex = Gender.indefined;
        }

        public Human(string name, string surname) : this()
        {
            Name = name;
            Surname = surname;
            _isLife = true;
        }

        public Human(string name, string surname, string nationality, Gender gender, int day, int month, int year) : this(name, surname)
        {
            Nationality = nationality;
            Sex = gender;
            _dateOfBirth = new DateTime(year, month, day);
            _age = DateTime.Now - _dateOfBirth;
        }
        public Human(string name, string surname, string nationality, Gender gender, int day, int month, int year, int dayOfDeath, int monthOfDeath, int yearOfDeath)
            : this(name, surname, nationality, gender, day, month, year)
        {
            _dateOfDeath = new DateTime(yearOfDeath, monthOfDeath, dayOfDeath);
            _age = _dateOfDeath - _dateOfBirth;
            _isLife = false;
        }

        public DateTime DateOfDeath
        {
            get=> _dateOfDeath;

            set
            {
                if (value > DateTime.MinValue && value > _dateOfBirth)
                {
                    _isLife = false;
                    _dateOfDeath = value;
                }
                else Console.WriteLine("Error");
            }
        }

        public DateTime DateOfBirth
        {
            get =>_dateOfBirth;

            set
            {
                if (_isLife)
                    _dateOfBirth = value;
                else if (value > DateOfDeath)
                    Console.WriteLine("Error! This person died earlier");
                else
                    _dateOfBirth = value;
            }
        }

        public int Age
        {
            get=> _age.Days / 365;  
        }

        public virtual void GetInfo()=>
        
            Console.WriteLine(_isLife ? @$"
        Имя: {Name}
        Фамилия: {Surname}
        Национальность:{Nationality}
        Дата рождения: {Convert.ToString(_dateOfBirth)}
        Возраст: {Convert.ToString(Age)} лет
        Пол: {Convert.ToString(Sex)}
        id: {Id}"
        :
        @$"
        Имя: {Name}
        Фамилия: {Surname}
        Национальность:{Nationality}
        Дата рождения: {Convert.ToString(_dateOfBirth)}
        Дата смерти: {Convert.ToString(_dateOfDeath)}
        Возраст: {Convert.ToString(Age)} лет
        Пол: {Convert.ToString(Sex)}
        id: {Id}");
        

        public void SetInfo(int day, int month, int year, string name, string surname, string nationality, int dayOfDeath, int monthOfDeath, int yearOfDeath)
        {
            _dateOfBirth = new DateTime(year, month, day);
            Name = name;
            Surname = surname;
            Nationality = nationality;
            _dateOfDeath = new DateTime(yearOfDeath, monthOfDeath, dayOfDeath);
            _age = _dateOfDeath - _dateOfBirth;
            _isLife = false;
        }

        public void SetInfo(string name, string surname, string nationality, Gender gender, int day, int month, int year)
        {
            _dateOfBirth = new DateTime(year, month, day);
            Name = name;
            Surname = surname;
            Nationality = nationality;
            _age = DateTime.Now - _dateOfBirth;
            _isLife = true;
            Sex = gender;
        }

        public virtual void Death(int dayOfDeath, int monthOfDeath, int yearOfDeath)
        {
            _isLife = false;
            _dateOfDeath = new DateTime(yearOfDeath, monthOfDeath, dayOfDeath);
            _age = _dateOfDeath - _dateOfBirth;

        }

        public virtual string this[int index]
        {
            get
            {
                return index switch
                {
                    0 => Name,
                    1 => Surname,
                    2 => Nationality,
                    3 => Convert.ToString(Sex),
                    4 => _dateOfBirth.ToString(),
                    5 => Convert.ToString(_age.Days / 365),
                    6 => Convert.ToString(Id),
                    7 => _isLife ? null : _dateOfDeath.ToString(),
                    _ => null
                };
            }
        }
    }
}
