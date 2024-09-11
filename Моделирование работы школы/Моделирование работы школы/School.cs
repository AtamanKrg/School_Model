namespace Моделирование_работы_школы
{
    public class School
    {
        public string Name;
        public List<Student> Students;

        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void PrintAllStudents()   //Вывод информации обо всех студентах (или об их отсутствии) на консоль
        {
            if (Students.Count == 0)
            {
                Console.WriteLine($"В школе {Name} пока нет учеников");
            }
            else
            {
                Console.WriteLine("{0, -3} {1, -10} {2, -10} {3, -13}","№", "Имя", "Фамилия", "Дата Рождения");
                for (int i = 0; i < Students.Count; i++)
                {
                    Console.WriteLine("{0, -3} {1, -10} {2, -10} {3, -13}", i + 1, Students[i].FirstName, Students[i].LastName, Students[i].DateOfBirth.ToString());
                }
            }
        }

        public void AddNewStudent(Student student)   //Добавление нового студента
        {
            Students.Add(student);
            Console.WriteLine($"Студент {student.PrintStudent()} успешно добавлен в школу {Name}");
        }

        public void RemoveStudent(int number)   //Удаление (отчисление) студента
        {
            if (number >= 1 && number <= Students.Count)
            {
                Console.WriteLine("Студент удалён.");
                Students.RemoveAt(number - 1);
            }
            else
            {
                Console.WriteLine("Ошибка! Данного порядкового номера не существует!");
            }
        }

    }
}