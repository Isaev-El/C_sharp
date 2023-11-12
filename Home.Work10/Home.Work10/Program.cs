using LibraryPerson;
using LibraryStudent;
using LibraryStudentWithAdvisor;
using LibraryTeacher;

namespace Home.Work10
{
    internal class Program
    {
        static void Main()
        {
            // Создание массива объектов
            Person[] people = new Person[10];
            for (int i = 0; i < 5; i++)
            {
                people[i] = Person.RandomPerson();
            }
            for (int i = 5; i < 8; i++)
            {
                people[i] = StudentWithAdvisor.RandomStudent();
            }
            for (int i = 8; i < 10; i++)
            {
                people[i] = Teacher.RandomTeacher();
            }

            // Использование операторов is, as и GetType
            int personCount = 0;
            int studentCount = 0;
            int teacherCount = 0;

            for (int i = 0; i < people.Length - 1; i++)
            {
                if (i + 1 < people.Length - 1) {
                    Person currentPerson = people[i];
                    Person nextPerson = people[i + 1];

                    bool areEqual = (currentPerson == nextPerson);
                    bool areNotEqual = (currentPerson != nextPerson);

                    Console.WriteLine(areEqual);
                    Console.WriteLine(areNotEqual);

                }

                if (people[i] is Person)
                {
                    personCount++;
 
                }

                if (people[i] is StudentWithAdvisor)
                {
                    studentCount++;
                    // Пример использования as для приведения к Student
                    StudentWithAdvisor? student = people[i] as StudentWithAdvisor;
                    if (student != null)
                    {
                        // Пример использования GetType
                        Console.WriteLine($"Student {student.Name} is of type {student.GetType()}");
                    }
                }

                if (people[i] is Teacher)
                {
                    teacherCount++;
                }
            }

            Console.WriteLine($"Total Persons: {personCount}, StudentWithAdvisor: {studentCount}, Teachers: {teacherCount}");

            // Перевод всех студентов на следующий курс
            foreach (var person in people)
            {
                if (person is StudentWithAdvisor student)
                {
                    student.Course++;
                    Console.WriteLine($"{student.Name} advanced to course {student.Course}");
                }
            }

            Console.WriteLine("TOSTRING");
            foreach (var person in people)
            {
                person.Print();
            }
        }
    }
}