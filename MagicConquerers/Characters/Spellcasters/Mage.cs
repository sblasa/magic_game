using System;
using MagicConquerers.Enums;
using MagicConquerers.Equipment.Armors.Light;
using MagicConquerers.Equipment.Weapons.Blunt;

namespace MagicConquerers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {



        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();


        public Mage()
            : this(Consts.Mage.NAME, 1)
        {

        }

        public Mage(string name, int level)
            :this(name, level, Consts.Mage.HEALTH_POINTS)
        {
        }


        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Mage.FACTION;
            base.ManaPoints = Consts.Mage.MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;

        }

        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public int Fireball()
        {
            return base.Weapon.DamagePoints + 10;

        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int Defend()
        {
            return this.Meditation();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
    }
}
