using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lesson6.Classwork
{
    public abstract class Persona
    {
        protected string FullName { get; set; }
        public DateTime DoB { get; set; }
        public abstract void ShowInfo();
        public virtual int Discount()
        {
            return 3;
        }

  
    }
}
