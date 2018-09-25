using System;


namespace MagicConquerers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;


        //constructor
        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
        {

        }


        public Staff(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        //method

        public void Empower()
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
