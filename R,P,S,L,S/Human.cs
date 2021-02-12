using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S
{
    class Human : PLayer
    {

        public int PickAGesture()
        {

            Console.WriteLine("Choose a gesture");

            string userInput = Console.ReadLine();
            int gestures = int.Parse(userInput);

            return gestures;


        }

    }
    

}
