using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicConquerers.Equipment.Armors.Light
{
    public class ClothRobe : Light
    {
        private const int DEFAULT_AMOR_POINTS = 10;
        public ClothRobe()
            : this(DEFAULT_AMOR_POINTS)
        {

        }

        public ClothRobe(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }


    }
}
