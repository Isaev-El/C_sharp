using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Polytech
{
    public class CallClass
    {
        public static string ReturnPerson(Person person)
        {
            string name = person.Name;
            int age = person.Age;
            string surname = person.Surname;

            return "Привет, меня зовут "+name+" "+surname +" и мне "+age+" лет.";
        }
    }
}
