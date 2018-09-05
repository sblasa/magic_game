
using MagicConquerers.Characters.Interfaces;
using MagicConquerers.Enums;
using System;

namespace MagicConquerers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Faction faction;
        private int healthPoints;
        private string name;
        private int level;


        public Faction Faction
        {
            get
            {
                return this.faction;
            }


            set
            {

                this.faction = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length > 3 && value.Length <= 12)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Name length should be between 3 and 12 characters");
                }
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "This value needs to be greater or equal to 0.");
                }
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                if (value >= 0)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "This value needs to be greater than or equal to 0.");
                }
            }
        }

        public abstract void Attack();

        public abstract void Defend();

        public abstract void SpecialAttack();
    }
}
