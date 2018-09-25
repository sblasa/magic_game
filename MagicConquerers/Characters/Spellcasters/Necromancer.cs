using System;
using MagicConquerers.Enums;
using MagicConquerers.Equipment.Armors.Leather;
using MagicConquerers.Equipment.Weapons.Sharp;

namespace MagicConquerers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "Horace";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 180;
        private const int DEFAULT_HEALTH_POINTS = 110;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();



        public Necromancer()
            : this("Autumn", 1)
        {

        }


        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }


        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
        }


        public void ShadowRage()
        {
            throw new NotImplementedException();

        }


        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
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
