using System;
using System.Collections.Generic;

namespace Моделирование_работы_школы
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте! Введите название вашей школы:");
            string schoolName = Console.ReadLine();
            School school = new (schoolName);
            Console.WriteLine($"Школа {schoolName} успешно создана!");

            while (true)
            {
                Console.WriteLine("Выберите действие: (введите номер)");
                Console.WriteLine($"1) Посмотреть список учеников школы {schoolName}");
                Console.WriteLine($"2) Добавить нового ученика в школу {schoolName}");
                Console.WriteLine($"3) Удалить (отчислить) ученика из школы {schoolName}");
                Console.WriteLine( "4) Выйти из программы");

                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == 1)
                {
                    Console.Clear();
                    school.PrintAllStudents();
                }

                else if (userAnswer == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Введите имя ученика:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Введите фамилию ученика:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Введите дату рождения ученика в формате ДД.ММ.ГГГГ:");
                    DateOnly dateOfBirth = DateOnly.Parse(Console.ReadLine());

                    Student student = new (firstName, lastName, dateOfBirth);
                    school.AddNewStudent(student);

                }

                else if (userAnswer == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Введите порядковый номер (№) ученика:");
                    int number = int.Parse(Console.ReadLine());
                    school.RemoveStudent(number);
                }
                else if (userAnswer == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Завершение работы...");
                    break;
                }
                Console.WriteLine();

            }
        }
    }
}