using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komkkh
{
       class Guy
        {
        public int Cash;
        public string Name;

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + "ma: " + Cash + "zł");
        }

        public int GiveCash(int amount)
        {
            if(amount <=0)
            {
                Console.WriteLine("Nie jest to poprawna kwota");
                return 0;
            }
            if(amount > Cash)
            {
                Console.WriteLine("Kwota jest większa niż możliwości");
                return 0;
            }
            Cash -= amount;
            return amount;
        }
        public void RecieveCash(int amount) 
        {
           if(amount <=0) 
            {
            Console.WriteLine("Nie da sie przyjąć 0 lub mniej.");
            }
           else
            {
                Cash += amount;
            }
        }

        
    }
}
