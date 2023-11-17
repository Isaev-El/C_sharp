using Practice.Work10.HouseParts;
using Practice.Work10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work10.TeamParts
{
    internal class TeamLeader : IWorker
    {
        public void RunWorker(IPart part)
        {
            Console.WriteLine("Бригадир");
            part.Build();
        }
        public void Report(House house) {
            house.ReportProgress();
        }
    }
}
