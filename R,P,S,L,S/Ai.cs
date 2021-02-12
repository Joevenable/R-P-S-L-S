using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S
{
   class Ai :PLayer
    {
        Random random;

        public int RandomGesture(int gestureIndex)
        {
           
            return random.Next(gestureIndex);
        }
    }
}
