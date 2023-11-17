using Practice.Work10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work10.TeamParts
{
    internal class Worker : IWorker
    {
        public int number { get; set; }
        public void RunWorker(IPart part)
        {
            part.Build();
        }


    }
}
