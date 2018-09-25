using Equipment.Interfaces;
using System;

namespace MagicConquerers.Equipment.Armors
{
    public abstract class Armor 
    {
        private int armorPoints;


        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }

            set
               
            {
                if (value >= 0)
                {
                    this.armorPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor points must be a positive number.");
                }
            }
        }

    }
}
