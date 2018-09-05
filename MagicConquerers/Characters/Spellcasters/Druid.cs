using System;
using MagicConquerers.Enums;
using MagicConquerers.Equipment.Armors.Leather;
using MagicConquerers.Equipment.Weapons.Blunt;

namespace MagicConquerers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Artemis";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 3;
        private const int DEFAULT_MANA_POINTS = 220;
        private const int DEFAULT_HEALTH_POINTS = 140;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();


        private LightLeatherVest bodyArmor;
        private Staff weapon;

  


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
            :this(DEFAULT_NAME, 1)
        {

        }


        public Druid(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Druid(string name, int level, int healthPoints)
        {
           base.Name = name;
           base.Level = level;
           base.HealthPoints = healthPoints;
           base.Faction = DEFAULT_FACTION;
           base.ManaPoints = DEFAULT_MANA_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
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

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }
    }
}
