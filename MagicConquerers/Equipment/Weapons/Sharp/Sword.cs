using System;



namespace MagicConquerers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;



        //constructor
        public Sword()
            : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Sword(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }


        //method
        public void Bloodthirst()
        {
            throw new NotImplementedException();

        }

        public override void Mend()
        {
            throw new NotImplementedException();
        }

        public override void Rebuild()
        {
            throw new NotImplementedException();
        }

    }
}
