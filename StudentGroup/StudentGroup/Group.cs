using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Group
    {
        private List<Student> students;

        public Group()
        {
            students = new List<Student>();
        }

        // Функция добавления студента в группу. Принимает экземпляр класса студент
        public void add(Student student)
        {
            students.Add(student);
        }

        // Функция удаления студента из группы. Принимает индекс студента подлежащего удалению
        public void delete(int index)
        {
            students.RemoveAt(index);
        }

        // Функция вывода всех студентов группы в консоль
        public void showAll()
        {
            int i = 0;
            foreach (Student student in students)
            {
                Console.Write($"{i++}) ");
                printStudent(student);
                Console.WriteLine();
            }
        }

        // Функция поиска и вывода в консоль студента в группе по имени
        public void findByName(String name)
        {
            Student student = students.Find(s => s.Name.Equals(name));
            if (student != null)
            {
                printStudent(student);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Студент не найден\n");
            }
        }

        // Функция поиска и вывода в консоль студента в группе по фамилии
        public void findBySurame(String surname)
        {
            Student student = students.Find(s => s.Surname.Equals(surname));
            if (student != null)
            {
                printStudent(student);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Студент не найден\n");
            }
        }

        // Функция поиска и вывода в консоль студента в группе по дате рождения
        public void findByBirthday(DateTime birthday)
        {
            Student student = students.Find(s => s.Birthsday.Equals(birthday));
            if (student != null)
            {
                printStudent(student);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Студент не найден\n");
            }
        }

        // Функция поиска и вывода в консоль студента в группе по оценке
        public void findByGrade(double grade)
        {
            Student student = students.Find(s => s.Grade.Equals(grade));
            if (student != null)
            {
                printStudent(student);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Студент не найден\n");
            }
        }

        // Функция вывода студента в консоль. Принимает экземпляр класса студент
        public void printStudent(Student student)
        {
            Console.Write($"{student.Surname} {student.Name} {student.Patronymic} - {student.Birthsday.ToString("dd/MM/yyyy")} - {student.Grade}");
        }
    }
}
