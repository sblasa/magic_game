using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicConquerers.Equipment.Weapons.Blunt
{
    public class Staff
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
        public Staff()
        {

        }

        //method

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
