using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Generics
{
    internal class Sword : Knight
    {
        public string ArmorColor { get; set; }

        public Sword()
        {

            ArmorColor = CreateRandomString(5);
        }
    }
}
