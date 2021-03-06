﻿using Equipment.Interfaces;
using System;


namespace MagicConquerers.Equipment.Weapons
{
    public abstract class Weapon : IRestore
    {
        //field
        private int damagePoints;

        public int DamagePoints
        {
            get
            {
                return damagePoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage points should be a positive number.");
                }
            }
        }

        public abstract void Mend();
        public abstract void Rebuild();
    }
}
