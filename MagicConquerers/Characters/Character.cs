
using MagicConquerers.Characters.Interfaces;
using MagicConquerers.Enums;
using MagicConquerers.Equipment.Armors;
using MagicConquerers.Equipment.Weapons;
using System;

namespace MagicConquerers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Faction faction;
        private int healthPoints;
        private string name;
        private int level;
        private Armor bodyArmor;
        private Weapon weapon;
        private bool isAlive;
        private int scores;




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

        public bool IsAlive
        {
            get
           {
                return this.isAlive;
            }

             set
            {
                isAlive = value;
            }
        }

        public int Scores
        {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
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

        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }



        public abstract int Attack();

        public abstract int Defend();

        public abstract int SpecialAttack();

        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + Defend();

                if(this.healthPoints <= 0)
                {
                    this.IsAlive = false;

                }

            }
             else
            {
                Console.WriteLine("Not enough damage to this character!");
            }
            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName} damage, and is now dead!");
            }
            else
            {
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName} damage, and now has {this.healthPoints} health points!");
            }
        }

        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }
}
