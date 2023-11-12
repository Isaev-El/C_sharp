using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Home.WorkWithInterfaces10
{
    [Serializable]
    public class CalculatorState
    {
        public double Memory { get; set; }
        public double LastResult { get; set; }

    }
}
