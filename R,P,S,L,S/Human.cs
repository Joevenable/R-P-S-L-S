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
            Console.WriteLine("Here are your gesture options");
            foreach (Gestures gesture in gestures)
            {
                Console.WriteLine($"{gesture.name}");
            }
            Console.WriteLine("Choose a gesture");
            
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "rock":
                    Console.WriteLine("you chose rock");
                    gesturesChoice = gestures[0].name;
                    break;
                case "paper":
                    Console.WriteLine("you chose paper");
                    gesturesChoice = gestures[1].name;
                    break;
                case "scissors":
                    Console.WriteLine("you chose scissors");
                    gesturesChoice = gestures[2].name;
                    break;
                case "lizard":
                    Console.WriteLine("you chose lizard");
                    gesturesChoice = gestures[3].name;
                    break;
                case "spock":
                    Console.WriteLine("you chose spock");
                    gesturesChoice = gestures[4].name;
                    break;
                default:
                    Console.WriteLine("not a valid choice choose again");
                    PickAGesture();
                    break;
            }

        }

        public override void PlayerName()
        {
            Console.WriteLine("please enter name");
            name = Console.ReadLine();
            
        }
    }
    

}
