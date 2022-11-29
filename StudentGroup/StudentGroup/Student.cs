using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Student
    {
        private String name;
        private String surname;
        private String patronymic;
        private DateTime birthsday;
        private double grade;

        public Student() { }

        public Student(string surname, string name, string patronymic, DateTime birthsday, double grade)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.birthsday = birthsday;
            this.grade = grade;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public DateTime Birthsday { get => birthsday; set => birthsday = value; }
        public double Grade { get => grade; set => grade = value; }
    }
}
