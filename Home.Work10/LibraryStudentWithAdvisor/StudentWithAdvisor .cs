

using LibraryPerson;
using LibraryStudent;
using LibraryTeacher;
using System;

namespace LibraryStudentWithAdvisor
{
    public class StudentWithAdvisor : Student
    {
        public Teacher Teacher { get; set; }
        private static Random random = new Random();

        public StudentWithAdvisor(int id, string name, string surname, int age, int course, string subject, Teacher teacher) : base(id, name, surname, age, course, subject)
        {
            Teacher = teacher;
        }

        public override string ToString()
        {
            string teacherInfo = "No teacher";

            if (Teacher != null)
            {
                // Включение информации о teacher в строковое представление
                teacherInfo = $"Teacher:{Teacher.Name}";
            }
            return $"{base.ToString()}\n{teacherInfo}";
        }

        public static new StudentWithAdvisor RandomStudent()
        {
            Person randomPerson = RandomPerson();
            int course = random.Next(1, 6);
            string[] subjects = { "Math", "Physics", "Computer Science", "Chemistry", "Biology" };
            string subject = subjects[random.Next(subjects.Length)];
            Teacher teacher = Teacher.RandomTeacher();

            return new StudentWithAdvisor(randomPerson.Id, randomPerson.Name, randomPerson.Surname, randomPerson.Age, course, subject,teacher);
        }

        public override void Print()
        {
            Console.WriteLine("STUDENT!!!");
            Console.WriteLine(ToString());
            Console.WriteLine();
        }
    }
}