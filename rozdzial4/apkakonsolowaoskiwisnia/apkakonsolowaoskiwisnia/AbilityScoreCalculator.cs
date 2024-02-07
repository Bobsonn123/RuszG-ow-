using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apkakonsolowaoskiwisnia
{
    internal class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            // Dzielenie wyniku rzutu przez pole DivideBy
            double divided = RollResult / DivideBy;

            // Dodawanie AddAmount do wyniku dzielenia
            int added = AddAmount + (int)divided;

            // Jeśli wynik jest za niski, użyj Minimum
            if(added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
}
