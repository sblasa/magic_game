using System;
using MagicConquerers.Equipment.Armors.Leather;
using MagicConquerers.Equipment.Weapons.Blunt;

namespace MagicConquerers.Characters.Spellcasters
{
    public class Druid
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LightLeatherVest bodyArmor;
        private Staff weapon;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "This value needs to be >= 0 and <= 10");
                }

            }

        }


        public string Faction
        {
            get
            {
                return this.faction;
            }


            set
            {
                if (value == "Melee" || value == "Spellcasters")
                {
                    this.faction = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "This is an incorrect faction.");
                }
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


        public LightLeatherVest BodyArmor
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


        public Staff Weapon
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

        public Druid()
            :this("Tish", 1)
        {

        }


        public Druid(string name, int level)
            : this(name, level, 120)
        {
        }

        public Druid(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = "Spellcasters";
            this.AbilityPoints = 100;
            this.Weapon = new Staff();
            this.BodyArmor = new LightLeatherVest();
        }

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();

        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
