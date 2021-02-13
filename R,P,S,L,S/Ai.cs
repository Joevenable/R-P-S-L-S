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

        public Ai()
        {
            random = new Random();

        }

        public override void PickAGesture()
        {
            int aiGesture = random.Next(gestures.Count);

            gesturesChoice = gestures[aiGesture].name;
        }

        public override void PlayerName()
        {
            name = "Rosc MKIV";
        }

       
    }
}
