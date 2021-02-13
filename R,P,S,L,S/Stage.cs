using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S
{
    class Stage
    {
        PLayer pLayer1;
        PLayer pLayer2;
        string gamemode;

        public Stage()
        {
           
            
        }

        public void Greeting()
        {
            Console.WriteLine("weclome to the most exciting game in the world!!!");
            Console.WriteLine("here are your rules");
            Console.WriteLine("Rock crushes Scissors, Scissors cuts Paper and Paper covers Rock as per usual");
            Console.WriteLine("Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");
            
        }

        public void SelectGameMode()
        {
            Console.WriteLine("please select single press 1 or multiplayer press 2");
            gamemode = Console.ReadLine();



            if (gamemode == "1")
            {
                Console.WriteLine("you have selcted single player Rosc will beat you for sure");
                pLayer1 = new Human();
                pLayer1.PlayerName();
                pLayer2 = new Ai();
                pLayer2.PlayerName();
            }
            else if (gamemode == "2")
            {
                Console.WriteLine("you hae selceted multiplayer best of luck to you both");
                pLayer1 = new Human();
                pLayer1.PlayerName();
                pLayer2 = new Human();
                pLayer2.PlayerName();
            }
            else
            {
                Console.WriteLine("Please select again");
                SelectGameMode();
            }     
            
        }

        public void WhoWon(string pLayer1, string pLayer2)
        {
            
            if (pLayer1 is "rock")
            {
                if (pLayer2 is "rock")
                {
                    Console.WriteLine("its a tie");
                }
                else if (pLayer2 is "paper")
                {
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"paper covers rock,{this.pLayer2.name} wins");             
                }

            }
        }

        public void Rungame()
        {
            Greeting();
            SelectGameMode();
            pLayer1.PickAGesture();
            pLayer2.PickAGesture();

        }
        public void DisplayWinner()
        {
            if (this.pLayer1.playerScore == 2)
            {
                Console.WriteLine("player one wins the game");
            }
            else if (this.pLayer2.playerScore == 2)
            {
                Console.WriteLine("player two wins the game");
            }


        }
    }
}

   
