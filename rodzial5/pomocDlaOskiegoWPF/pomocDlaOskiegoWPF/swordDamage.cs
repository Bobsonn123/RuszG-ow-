using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomocDlaOskiegoWPF
{
    internal class swordDamage
    {
        private static Random R = new Random();
        /// <summary>
        /// Pierwsza rzecz w kodzie, robi ze początkowy rzut jest rowny startingRoll, potem nie wylowywana.
        /// </summary>
        /// <param name="startingRoll"></param>
        public swordDamage(int startingRoll) 
        {
            roll = startingRoll;
            CalculateDamage();
        }
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;
        public int Damage { get; private set; }

        private int roll;
        /// <summary>
        /// Zwraca wynik rzutu
        /// </summary>
        public int Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        /// <summary>
        /// Zwraca czy broń jest ognista
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }

            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        private bool magic;
        /// <summary>
        /// Zwraca czy broń jest magiczna
        /// </summary>
        public bool Magic
        {
            get
            {
                return magic;
            }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// Oblicza obrażenia miecza, sprawdza czy jest magiczny i czy jest ognisty
        /// </summary>
        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }

        
        
    }
}
