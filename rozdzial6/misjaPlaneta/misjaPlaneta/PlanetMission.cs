using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misjaPlaneta
{
    abstract class PlanetMission
    {
        protected float fuelPerKm;
        protected long kmPerHour;
        protected long kmToPlanet;

        public string MissionInfo()
        {
            long fuel = (long)(kmToPlanet * fuelPerKm);
            long time = kmToPlanet / kmPerHour;
            return $"Spalimy {fuel} jednostek paliwa w czasie {time}";
        }
    }
}
