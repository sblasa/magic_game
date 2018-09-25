using System;


namespace MagicConquerers.Equipment.Weapons.Sharp

{
    public class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;


        public Axe()
            : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Axe(int armorPoints)
        {
            this.DamagePoints = armorPoints;

        }


        public void HacNSlash()
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
