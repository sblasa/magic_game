using System;
using MagicConquerers.Enums;
using MagicConquerers.Equipment.Armors.Heavy;
using MagicConquerers.Equipment.Weapons.Sharp;

namespace MagicConquerers.Characters.Melee
{
    public class Warrior : Melee
    {
        private const string DEFAULT_NAME = "Braveheart";
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 200;
        private const int DEFAULT_HEALTH_POINTS = 115;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();




        public Warrior()
            :this (DEFAULT_NAME, 1)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = DEFAULT_NAME;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
           base.Weapon = DEFAULT_WEAPON ;
           base.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.Strike();
        }

        public override void Defend()
        {
            this.SkinHarden();
        }

        public override void SpecialAttack()
        {
            this.Execute();
        }
    }
}
