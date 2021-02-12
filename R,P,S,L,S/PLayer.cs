using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S
{
    abstract class PLayer
    {
        
        public List<Gestures> gestures;
        public string name;



        public PLayer()
        {
            
            Gestures rock = new Gestures ("rock");
            Gestures paper = new Gestures("paper");
            Gestures scissors = new Gestures("scossors");
            Gestures lizard = new Gestures("lizard");
            Gestures spock = new Gestures("spock");

            gestures = new List<Gestures>();

            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);
        }

        public string PlayerName()
    }
}
