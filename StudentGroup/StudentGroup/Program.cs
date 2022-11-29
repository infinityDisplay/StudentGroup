using System;

namespace StudentGroup
{


    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра класса группа
            Group group = new Group();

            // Добавление в группу студентов
            group.add(new Student("Иванова", "Анна", "Игоревна", new DateTime(2003, 6, 12), 4.1));
            group.add(new Student("Петров", "Кирилл", "Алексеевич", new DateTime(2002, 2, 14), 4.2));
            group.add(new Student("Андреев", "Филипп", "Кириллович", new DateTime(2002, 4, 22), 3));
            group.add(new Student("Медведева", "Ирина", "Марковна", new DateTime(2002, 3, 11), 4.3));
            group.add(new Student("Сидоров", "Алексей", "Романович", new DateTime(2001, 2, 25), 5));

            bool isRunning = true;
            Console.WriteLine("Введите команду. Для вывода списка команд введите \"помощь\"");
            // Цикл программы(по аналогии с консолью и ее командами)
            do
            {
                Console.Write("Введите команду: ");
                String request = Console.ReadLine();
                String temp;
                double grade;
                int day, month, year;
                DateTime date;
                
                // Обработка команд
                switch (request)
                {
                    case "помощь":
                        Console.WriteLine("\"студенты\" - вывод всех студентов группы\n" +
                                          "\"поиск\" - поиск студента в группе...\n" +
                                          "\"добавить\" - добавление студента в группу...\n" +
                                          "\"удалить\" - удаление студента из группы...\n" +
                                          "\"выход\" - выход из программы\n");
                        break;

                    case "студенты":
                        group.showAll();
                        Console.WriteLine();
                        break;

                    case "поиск":
                        Console.WriteLine("Введите критерий поиска(\"имя\" / \"фамилия\" / \"дата рождения\" / \"успеваемость\": ");
                        String find = Console.ReadLine();

                        // Обработка критериев поиска
                        switch (find)
                        {
                            case "имя":
                                Console.Write("Введите имя: ");
                                temp = Console.ReadLine();
                                group.findByName(temp);
                                break;

                            case "фамилия":
                                Console.Write("Введите фамилию: ");
                                temp = Console.ReadLine();
                                group.findBySurame(temp);
                                break;

                            case "дата рождения":
                                try
                                {
                                    Console.WriteLine("Введите дату рождения: ");
                                    Console.Write("Введите день(dd): ");
                                    day = int.Parse(Console.ReadLine());
                                    Console.Write("Введите номер месяца(MM): ");
                                    month = int.Parse(Console.ReadLine());
                                    Console.Write("Введите год(yyyy): ");
                                    year = int.Parse(Console.ReadLine());
                                    date = new DateTime(year, month, day);
                                    group.findByBirthday(date);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Ошибка при вводе даты рождения. " + e.Message);
                                }
                                break;

                            case "успеваемость":
                                try
                                {
                                    Console.Write("Введите оценку: ");
                                    grade = Convert.ToDouble(Console.ReadLine());
                                    group.findByGrade(grade);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Ошибка при вводе успеваемости. " + e.Message);
                                }
                                break;
                            default:
                                break;
                        }
                        break;

                    case "добавить":
                        try
                        {
                            Student student = new Student();

                            Console.Write("Введите фамилию: ");
                            temp = Console.ReadLine();
                            student.Surname = temp;

                            Console.Write("Введите имя: ");
                            temp = Console.ReadLine();
                            student.Name = temp;

                            Console.Write("Введите отчество: ");
                            temp = Console.ReadLine();
                            student.Patronymic = temp;

                            Console.WriteLine("Введите дату рождения: ");
                            Console.Write("Введите день(dd): ");
                            day = int.Parse(Console.ReadLine());

                            Console.Write("Введите номер месяца(MM): ");
                            month = int.Parse(Console.ReadLine());

                            Console.Write("Введите год(yyyy): ");
                            year = int.Parse(Console.ReadLine());
                            date = new DateTime(year, month, day);
                            student.Birthsday = date;

                            Console.Write("Введите оценку: ");
                            grade = Convert.ToDouble(Console.ReadLine());
                            student.Grade = grade;

                            group.add(student);
                            Console.Write($"Студент успешно добавлен: ");
                            group.printStudent(student);
                            Console.WriteLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка при вводе данных студента. " + e.Message);
                        }
                        Console.WriteLine();
                        break;

                    case "удалить":
                        group.showAll();
                        Console.Write("Введите индекс студента, которого необходимо удалить: ");
                        try
                        {
                            int ind = Convert.ToInt32(Console.ReadLine());
                            group.delete(ind);
                            Console.WriteLine("Студент усешно удален\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка при удвлении студента. " + e.Message);
                        }
                        break;

                    case "выход":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Неверная команда. Для вывода списка команд наберите \"помощь\"\n");
                        break;
                }
            } while (isRunning);
        }
    }
}
