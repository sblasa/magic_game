using System;
using MagicConquerers.Enums;
using MagicConquerers.Equipment.Armors.Leather;
using MagicConquerers.Equipment.Weapons.Sharp;

namespace MagicConquerers.Characters.Melee
{
    public class Assassin : Melee
    {
        private const string DEFAULT_NAME = "Nakita";
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_LEVEL = 2;
        private const int DEFAULT_ABILITY_POINTS = 215;
        private const int DEFAULT_HEALTH_POINTS = 150;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private LightLeatherVest bodyArmor;
        private Sword weapon;



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


        public Sword Weapon
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


        public Assassin()
            :this(DEFAULT_NAME, 1)
        {

        }


        public Assassin(string name, int level)
            :this(name, level, DEFAULT_HEALTH_POINTS)
        {
            this.Name = name;
            this.Level = level;
        }

        public Assassin(string name, int level, int healthPoints)
        {
           base.Name = name;
           base.Level = level;
           base.HealthPoints = healthPoints;
           base.Faction = DEFAULT_FACTION;
           base.AbilityPoints = DEFAULT_HEALTH_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void Raze()
        {
            throw new NotImplementedException();

        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
