using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.WordOfTanks
{
    public class Tank
    {
        private string TankName { get; set; }
        private int AmmoLevel { get; set; }
        private int ArmorLevel {  get; set; }
        private int ManeuverabilityLevel {  get; set; }

        private static Random random = new Random();

        public string GetTankName()
        {
            return TankName;
        }

        public Tank(string name)
        {
            TankName = name;
            try
            {
                AmmoLevel = random.Next(0, 101);
                ArmorLevel = random.Next(0, 101);
                ManeuverabilityLevel = random.Next(0, 101);
            }
            catch (Exception ex)
            {
                throw new TankInitializationException(TankName, AmmoLevel, ArmorLevel, ManeuverabilityLevel, "Error initializing tank parameters.", ex);
            }
        }

        public override string ToString()
        {
            return $"Tank: {TankName}\n" +
                   $"Ammo Level: {AmmoLevel}%\n" +
                   $"Armor Level: {ArmorLevel}%\n" +
                   $"Maneuverability Level: {ManeuverabilityLevel}%";
        }

        public static bool operator *(Tank tank1, Tank tank2)
        {
            int winCriteria = 0;

            if (tank1.AmmoLevel > tank2.AmmoLevel)
                winCriteria++;
            if (tank1.ArmorLevel > tank2.ArmorLevel)
                winCriteria++;
            if (tank1.ManeuverabilityLevel > tank2.ManeuverabilityLevel)
                winCriteria++;

            return winCriteria >= 2;
        }
    }       
}
