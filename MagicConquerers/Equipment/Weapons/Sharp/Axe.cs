using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicConquerers.Equipment.Weapons.Sharp

{
    public class Axe
    {
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }

            set
            {
                damage = value;
            }



        }

        public Axe()
        {

        }


        public void HacNSlash()
        {
            throw new NotImplementedException();

        }
    }
}
