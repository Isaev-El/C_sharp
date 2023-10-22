using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Polytech;

namespace ConsoleApp.Polytech
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Elkhan", "Isaev", 20);

            Console.WriteLine(CallClass.ReturnPerson(person));
            Console.WriteLine("Subject - "+Constant.Subject+ "\nBachelor - " + Constant.Bachelor+ "\nCourse - " + Constant.Course);
            Console.ReadLine();
        }
    }
}
