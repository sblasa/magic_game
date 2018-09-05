using System;
using MagicConquerers.Enums;
using MagicConquerers.Equipment.Armors.Heavy;
using MagicConquerers.Equipment.Weapons.Blunt;

namespace MagicConquerers.Characters.Melee
{
    public class Knight : Melee
    {

        private const string DEFAULT_NAME = "Lady Justine";
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 210;
        private const int DEFAULT_HEALTH_POINTS = 120;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();



        private string name;
        private Chainlink bodyArmor;
        private Hammer weapon;



        public Chainlink BodyArmor
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


        public Hammer Weapon
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

        public Knight()
            :this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }


        public Knight(string name, int level)
            :this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Knight(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
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
