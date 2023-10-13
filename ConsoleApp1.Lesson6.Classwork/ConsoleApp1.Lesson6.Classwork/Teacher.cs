using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lesson6.Classwork
{
    public class Teacher: Persona
    {
        public int Students { get; set; }
        public int Salary { get; set; }
        public List<string> ListOfSubjects { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Препод {0}, {1:yyyyyy} года рождения, {2} курса", FullName, DoB, Course);
        }
        public override int Discount()
        {
            return base.Discount()+5;
        }
    }
}
