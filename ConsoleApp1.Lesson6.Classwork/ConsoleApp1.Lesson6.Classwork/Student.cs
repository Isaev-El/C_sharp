using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lesson6.Classwork
{
    public class Student: Persona
    {
        public int Course { get; set; }
        public List<string> ListOfSubject { get; set; }
        public double GPA { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Студент {0}, {1:yyyyyy} года рождения, {2} курса", FullName, DoB, Course);
        }
    }
}
