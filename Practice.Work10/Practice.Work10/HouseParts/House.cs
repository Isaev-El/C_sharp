using Practice.Work10.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work10.HouseParts
{
    internal class House
    {
        private List<IPart> Parts;
        private int currentPartIndex;

        public House() {

            Parts = new List<IPart> {
            new Basement(),
            new Walls(),
            new Walls(),
            new Walls(),
            new Walls(),
            new Door(),
            new Window(),
            new Window(),
            new Window(),
            new Window(),
            new Roof()
            };

            currentPartIndex = 0;
        }

        public IPart GetNextPart()
        {
            if (currentPartIndex<Parts.Count)
            {
                return Parts[currentPartIndex++];
            }
            else
            {
                return null;
            }
        }
        public bool IsBuildingComplete()
        {
            return currentPartIndex >= Parts.Count;
        }

        public void ReportProgress()
        {
            Console.WriteLine("Отчет о строительстве:");
            Console.WriteLine("Фундамент построен: {0}", Parts[0] is Basement);
            Console.WriteLine("Стены построены: {0}", Parts[1] is Walls && Parts[2] is Walls && Parts[3] is Walls && Parts[4] is Walls);
            Console.WriteLine("Дверь построена: {0}", Parts[5] is Door);
            Console.WriteLine("Окна построены: {0}", Parts[6] is Window && Parts[7] is Window && Parts[8] is Window && Parts[9] is Window);
            Console.WriteLine("Крыша построена: {0}", Parts[10] is Roof);
        }
        public void Draw()
        {
            Console.WriteLine("   _______");
            Console.WriteLine("  /       \\");
            Console.WriteLine(" /         \\");

            Console.WriteLine("|  _     _  |");
            Console.WriteLine("| |_|   |_| |");
            Console.WriteLine("|  _     _  |");
            Console.WriteLine("| |_|__ |_| |");
            Console.WriteLine("|   | .|    |");
            Console.WriteLine("|___|__|____|");

        }
    }
}
