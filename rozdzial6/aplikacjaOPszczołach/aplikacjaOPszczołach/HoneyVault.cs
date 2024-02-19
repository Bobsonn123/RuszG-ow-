using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacjaOPszczołach
{
    internal static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .50f;
        public const float LOW_LEVEL_WARNING = 10f;

        private static float honey = 100f;

        private static float nectar = 250f;

        public static void ConvertNectarToHoney(float amount)
        {

            if(amount > nectar) amount = nectar; 
            nectar -= amount;
            honey += (amount * NECTAR_CONVERSION_RATIO);
           
        }

        public static bool ConsumeHoney(float amount)
        {
            if(amount <= honey)
            {
                honey -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CollectNectar(float amount)
        {
            if(amount > 0) nectar += amount;
        }

        public static string StatusReport 
        {
            get
            {
                string status = $"ilość miodu: {honey:0.0} \nilość nektaru: {nectar:0.0}\n";

                string honeyWarning = "MAŁO MIODU - DODAJ PRODUCENTÓW MIODU\n";
                string nectarWarning = "MAŁO NEKTARU - DODAJ PRODUCENTÓW NEKTARU\n";
                string warning = "";
                if (honey < LOW_LEVEL_WARNING) warning += honeyWarning;

                if (nectar < LOW_LEVEL_WARNING) warning += nectarWarning;

                return status + warning;
            }
        }
        
    }
}
