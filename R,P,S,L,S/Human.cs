using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S
{
    class Human : PLayer
    {

        public override void PickAGesture()
        {
            
            foreach (Gestures gesture in gestures)
            {
                Console.WriteLine($"Here are your gesture options {gesture.name}");
            }
            Console.WriteLine("Choose a gesture");

            string userInput = Console.ReadLine();
            int hand = int.Parse(userInput);
            gesturesChoice = gestures[hand].name;
        }

        public override void PlayerName()
        {
            Console.WriteLine("please enter first name");
            string userInput = Console.ReadLine();
            
        }
    }
    

}
