using System;

namespace LibraryPerson
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, string surname, int age)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nAge: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person other = (Person)obj;
            return Id == other.Id && Name == other.Name && Surname == other.Surname && Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Surname, Age);
        }

        public static bool operator ==(Person person1, Person person2)
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

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();

        }

        private static Random random = new Random();

        public static Person RandomPerson()
        {
            int id = random.Next(1000, 9999);
            string[] names = { "Alice", "Bob", "Charlie", "David", "Eva" };
            string[] surnames = { "Smith", "Johnson", "Williams", "Jones", "Brown" };
            string name = names[random.Next(names.Length)];
            string surname = surnames[random.Next(surnames.Length)];
            int age = random.Next(18, 65);

            return new Person(id, name, surname, age);
        }
    }
}
