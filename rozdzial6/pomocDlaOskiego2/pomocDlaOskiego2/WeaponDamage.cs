using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomocDlaOskiego2
{
    abstract class WeaponDamage
    {
        public virtual int Damage { get; protected set; }
        protected abstract void CalculateDamage();
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
        protected int roll;
        public virtual int Roll
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
        protected bool flaming;
        public virtual bool Flaming
        {
            get { return flaming; }

            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        protected bool magic;
        public virtual bool Magic
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
        
    }
}
