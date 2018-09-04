using System;


namespace MagicConquerers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        //constructor
        public Hammer()
            : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Hammer(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }


        //method 

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
