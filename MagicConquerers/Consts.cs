using MagicConquerers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicConquerers
{
    public static class Consts
    {
        public static class Warrior { 
        public const string NAME = "Braveheart";
        public const Faction FACTION = Faction.Melee;
        public const int LEVEL = 1;
        public const int ABILITY_POINTS = 200;
        public const int HEALTH_POINTS = 115;

        }

        public static class Mage { 

        public const string NAME = "Isabella";
        public const Faction FACTION = Faction.Spellcaster;
        public const int LEVEL = 2;
        public const int MANA_POINTS = 180;
        public const int HEALTH_POINTS = 160;
        public const int ABILITY_POINTS = 100;

        }

    }
}
