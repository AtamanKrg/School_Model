namespace Моделирование_работы_школы
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public DateOnly DateOfBirth;

        public Student(string firstName, string lastName, DateOnly dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string PrintStudent()   //Вывод имени и фамилии студента на консоль
        {
            return FirstName + " " + LastName;
        }
    }
}