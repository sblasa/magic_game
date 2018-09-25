

using MagicConquerers.Characters;
using MagicConquerers.Characters.Melee;
using MagicConquerers.Characters.Spellcasters;
using System.Collections.Generic;

namespace MagicConquerers
{
    class EnterHere
    {
        static void Main(string[] args)
        {


            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Knight(),
                new Assassin(),
                new Druid(),
                new Mage(),
                new Necromancer()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellcastersTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if(character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if(character is Spellcaster)
                {
                    spellcastersTeam.Add((Spellcaster)character); 
                }
          
            }


        }
    }
}
