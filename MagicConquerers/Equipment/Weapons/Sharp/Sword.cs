using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicConquerers.Equipment.Weapons.Sharp
{
    public class Sword
    {


        //field
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

        //constructor
        public Sword()
        {

        }


        //method
        public void BloodThirst()
        {
            throw new NotImplementedException();

        }
    }
}
