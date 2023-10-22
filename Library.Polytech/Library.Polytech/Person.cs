using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Polytech
{
    public class Person
    {
        public int Age { get; set; }
        public string Name  { get; set; }
        public string Surname { get; set; }
        public Person(string Name, string Surname, int Age)
        {
            this.Age = Age;
            this.Name = Name;
            this.Surname = Surname;
        }


    }
}
