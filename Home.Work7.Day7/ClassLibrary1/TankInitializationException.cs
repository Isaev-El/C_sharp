using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class TankInitializationException : Exception
    {
        public string TankName { get; private set; }
        public int AmmoLevel { get; private set; }
        public int ArmorLevel { get; private set; }
        public int ManeuverabilityLevel { get; private set; }

        public TankInitializationException(string tankName, int ammoLevel, int armorLevel, int maneuverabilityLevel)
            : base($"Error initializing tank parameters for tank '{tankName}'.")
        {
            TankName = tankName;
            AmmoLevel = ammoLevel;
            ArmorLevel = armorLevel;
            ManeuverabilityLevel = maneuverabilityLevel;
        }

        public TankInitializationException(string tankName, int ammoLevel, int armorLevel, int maneuverabilityLevel, string message)
            : base(message)
        {
            TankName = tankName;
            AmmoLevel = ammoLevel;
            ArmorLevel = armorLevel;
            ManeuverabilityLevel = maneuverabilityLevel;
        }

        public TankInitializationException(string tankName, int ammoLevel, int armorLevel, int maneuverabilityLevel, string message, Exception innerException)
            : base(message, innerException)
        {
            TankName = tankName;
            AmmoLevel = ammoLevel;
            ArmorLevel = armorLevel;
            ManeuverabilityLevel = maneuverabilityLevel;
        }
    }

}
