using LibraryPerson;
using System;

namespace LibraryStudent
{
    public class Student : Person
    {
        public int Course { get; set; }
        public string Subject { get; set; }

        public Student(int id, string name, string surname, int age, int course, string subject)
            : base(id, name, surname, age)
        {
            Course = course;
            Subject = subject;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCourse: {Course}\nSubject: {Subject}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Student other = (Student)obj;
            return Id == other.Id && Name == other.Name && Surname == other.Surname && Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Surname, Age);
        }

        public static bool operator ==(Student person1, Student person2)
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

        public static bool operator !=(Student person1, Student person2)
        {
            return !(person1 == person2);
        }

        public override void Print()
        {
            Console.WriteLine("STUDENT!!!");
            Console.WriteLine(ToString());
        }

        private static Random random = new Random();

        public static Student RandomStudent()
        {
            Person randomPerson = RandomPerson();
            int course = random.Next(1, 6);
            string[] subjects = { "Math", "Physics", "Computer Science", "Chemistry", "Biology" };
            string subject = subjects[random.Next(subjects.Length)];

            return new Student(randomPerson.Id, randomPerson.Name, randomPerson.Surname, randomPerson.Age, course, subject);
        }
    }
}
