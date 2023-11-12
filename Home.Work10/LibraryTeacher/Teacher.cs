using LibraryPerson;
using LibraryStudent;
using System;
using System.Linq;

namespace LibraryTeacher
{
    public class Teacher : Person
    {
        public int Salary { get; set; }
        public Student[] Students { get; set; }

        private static Random random = new Random();

        public Teacher(int id, string name, string surname, int age, Student[] students, int salary)
            : base(id, name, surname, age)
        {
            Students = students;
            Salary = salary;
        }

        public override string ToString()
        {
            string studentsInfo = "No students";

            if (Students != null && Students.Length > 0)
            {
                studentsInfo = $"Students: {string.Join(", ", Students.Select(student => $"{student.Name} (ID: {student.Id})"))}";
            }
            return $"{base.ToString()}\nSalary: {Salary}\n{studentsInfo}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Teacher other = (Teacher)obj;
            return Id == other.Id && Name == other.Name && Surname == other.Surname && Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Surname, Age);
        }

        public static bool operator ==(Teacher person1, Teacher person2)
        {
            if (ReferenceEquals(person1, person2))
            {
                return true;
            }

            if (person1 is null || person2 is null)
            {
                return false;
            }

            return person1.Equals(person2);
        }

        public static bool operator !=(Teacher person1, Teacher person2)
        {
            return !(person1 == person2);
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();

        }
        public static Teacher RandomTeacher()
        {
            Person randomPerson = RandomPerson();
            int salary = random.Next(30000, 90000);
            int numStudents = random.Next(0, 5);
            Student[] students = new Student[numStudents];

            for (int i = 0; i < numStudents; i++)
            {
                students[i] = Student.RandomStudent();
            }

            return new Teacher(randomPerson.Id, randomPerson.Name, randomPerson.Surname, randomPerson.Age, students, salary);
        }
    }
}
