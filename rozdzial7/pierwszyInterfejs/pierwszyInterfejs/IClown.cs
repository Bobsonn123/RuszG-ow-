using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszyInterfejs
{
    internal interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();
        protected static Random random = new Random();

        private static int carCapacity = 12;

        public static int CarCapacity
        {
            get { return carCapacity; }
            set
            {
                if (value > 10) carCapacity = value;
                else Console.Error.WriteLine($"Uwaga: pojemność autka, {value}, jest za mała");
            }
        }

        public static string ClownCarDescription()
        {
            return $"Liczba klaunów w autku. {random.Next(CarCapacity / 2, CarCapacity)}";
        }

    }
}
