﻿using System;
using MagicConquerers.Enums;
using MagicConquerers.Equipment.Armors.Light;
using MagicConquerers.Equipment.Weapons.Blunt;

namespace MagicConquerers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {

        private const string DEFAULT_NAME = "Isabella";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 2;
        private const int DEFAULT_MANA_POINTS = 180;
        private const int DEFAULT_HEALTH_POINTS = 160;
        private const int DEFAULT_ABILITY_POINTS = 100;


        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();


        public Mage()
            : this(DEFAULT_NAME, 1)
        {

        }

        public Mage(string name, int level)
            :this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }


        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();

        }

        public void Meditation()
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
