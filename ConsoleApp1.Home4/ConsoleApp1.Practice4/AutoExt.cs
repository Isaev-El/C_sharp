using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practice4
{
    public partial class Car
    {
        public void TheCarIsInAnEmergencyCondition(bool flag)
        { 
            
            if (flag == true)
            {
               price -= price * 0.3;
            }
            Console.WriteLine($"Car's price:{price}"+" because она аварийная, поэтому скидка 30%");
            
        }
    }
}
