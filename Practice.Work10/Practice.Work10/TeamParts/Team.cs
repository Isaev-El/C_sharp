using Practice.Work10.HouseParts;
using Practice.Work10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work10.TeamParts
{
    internal class Team
    {
        public List<IWorker> Workers { get; set; }

        public Team() {

            Workers = new List<IWorker>() {};

        }

        public void AddWorker(IWorker worker)
        {
            Workers.Add(worker);
        }

        public void Building(House house) { 
            foreach (IWorker worker in Workers)
            {
                if (worker is TeamLeader)
                {
                    ((TeamLeader)worker).Report(house);
                }
                else
                {
                    IPart part = house.GetNextPart();
                    if (part != null) { 
                        worker.RunWorker(part);
                    }
                }
            }
        }



    }
}
