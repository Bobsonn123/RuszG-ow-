using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomocDlaOskiego2
{
    internal class ArrowDamage
    {
        private static Random R = new Random();
        /// <summary>
        /// Pierwsza rzecz w kodzie, robi ze początkowy rzut jest rowny startingRoll, potem nie wylowywana.
        /// </summary>
        /// <param name="startingRoll"></param>
        public ArrowDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;
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
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage += (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
            
        }
    }
}
