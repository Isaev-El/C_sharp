using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home.Work11.Enum;

namespace Home.Work11.Model
{
    internal struct Employee
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public Sex Sex { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}\nSurname:{Surname}\nSalary:{Salary}\nJoiningDate:{JoiningDate}\nSex:{Sex}\nPosition:{Position}\n";
        }
    }
}
