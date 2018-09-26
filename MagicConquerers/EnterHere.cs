

using MagicConquerers.Characters;
using MagicConquerers.Characters.Melee;
using MagicConquerers.Characters.Spellcasters;
using System;
using System.Collections.Generic;

namespace MagicConquerers
{
    class EnterHere
    {


        static void Main()
        {

            Random rng = new Random();
            bool gameOver = false;

            Melee currentMelee;
            Spellcaster currentSpellcaster;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                //new Knight(),
                //new Assassin(),
                //new Druid(),
                new Mage(),

                //new Necromancer()
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

            while(!gameOver)
            {
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                currentSpellcaster = rng.Next(0, spellcastersTeam.Count);


                spellcastersTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name);

                if (!spellcastersTeam[currentSpellcaster].IsAlive)

                {
                    meleeTeam[currentMelee].WonBattle();
                    spellcastersTeam.Remove(spellcastersTeam[currentSpellcaster]);

                    if (spellcastersTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!");
                        break;

                    }

                    else
                    {
                        currentSpellcaster = rng.Next(0, spellcastersTeam.Count);

                    }


                }

                meleeTeam[currentMelee].TakeDamage(spellcastersTeam[currentSpellcaster].Attack(), spellcastersTeam[currentSpellcaster].Name);


                if (!meleeTeam[currentMelee].IsAlive)
                {
                    spellcastersTeam[currentSpellcaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMelee]);

                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spellcaster team wins!");
                        break;

                    }

                    else
                    {
                        currentMelee = rng.Next(0, meleeTeam.Count);

                    }


                }

                //5. If no characters are alive from either teams, then gameOver = true
            }
        }
    }
}
