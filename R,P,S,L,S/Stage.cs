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
        string playAgain;

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
                else if (pLayer2 is "scissors")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"rock crushes scissors,{this.pLayer1.name} wins");
                }
                else if (pLayer2 is "lizard")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"rock crushes lizard,{this.pLayer1.name} wins");
                }
                else if (pLayer2 is "spock")
                {
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"spock vaporizes rock,{this.pLayer2.name} wins");
                }

            }
            if (pLayer1 is "paper")
            {
                if (pLayer2 is "rock")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"paper covers rock,{this.pLayer1.name} wins");
                }
                else if (pLayer2 is "paper")
                {
                    Console.WriteLine($"Its a tie");
                }
                else if (pLayer2 is "scissors")
                {
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"scissors cut paper,{this.pLayer2.name} wins");
                }
                else if (pLayer2 is "lizard")
                {
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"lizard eats paper,{this.pLayer2.name} wins");
                }
                else if (pLayer2 is "spock")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"paper disproves spock,{this.pLayer1.name} wins");
                }

            }
            if (pLayer1 is "scissors")
            {
                if (pLayer2 is "rock")
                {   
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"rock crushes scissors,{this.pLayer2.name} wins");
                }
                else if (pLayer2 is "paper")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"scissors cut paper,{this.pLayer1.name} wins");
                }
                else if (pLayer2 is "scissors")
                {
                    Console.WriteLine("its a tie");
                }
                else if (pLayer2 is "lizard")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"scissors decapitates lizard,{this.pLayer1.name} wins");
                }
                else if (pLayer2 is "spock")
                {
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"spock smashes scissors,{this.pLayer2.name} wins");
                }

            }
            if (pLayer1 is "lizard")
            {
                if (pLayer2 is "rock")
                {
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"rock crushes lizard,{this.pLayer2.name} wins");
                }
                else if (pLayer2 is "paper")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"Lizard eats paper,{this.pLayer1.name} wins");
                }
                else if (pLayer2 is "scissors")
                {
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"scissors decapitates lizard,{this.pLayer2.name} wins");
                }
                else if (pLayer2 is "lizard")
                {
                    
                    Console.WriteLine("its a tie");
                }
                else if (pLayer2 is "spock")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"lizard poisions spock,{this.pLayer1.name} wins");
                }

            }
            if (pLayer1 is "spock")
            {
                if (pLayer2 is "rock")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"spock vaporizes rock,{this.pLayer1.name} wins");
                }
                else if (pLayer2 is "paper")
                {
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"paper disproves spock,{this.pLayer2.name} wins");
                }
                else if (pLayer2 is "scissors")
                {
                    this.pLayer1.playerScore++;
                    Console.WriteLine($"spock smashes scissors,{this.pLayer1.name} wins");
                }
                else if (pLayer2 is "lizard")
                {
                    this.pLayer2.playerScore++;
                    Console.WriteLine($"lizard poisions spock,{this.pLayer2.name} wins");
                }
                else if (pLayer2 is "spock")
                {
                    Console.WriteLine("its a tie");
                }

            }

        }

        public void Rungame()
        {
            Greeting();
            SelectGameMode();
            while (pLayer1.playerScore < 2 && pLayer2.playerScore < 2)
            {
                pLayer1.PickAGesture();
                pLayer2.PickAGesture();
                WhoWon(pLayer1.gesturesChoice, pLayer2.gesturesChoice);
                DisplayWinner();
                
            }
           PLayAgain();
           
        }
        public void DisplayWinner()
        {
            if (this.pLayer1.playerScore == 2)
            {
                Console.WriteLine($"{this.pLayer1.name} wins the game");
                
            }
            else if (this.pLayer2.playerScore == 2)
            {
                Console.WriteLine($"{this.pLayer2.name} wins the game");
               
            }


        }
        public void PLayAgain()
        {
            Console.WriteLine("Would you like to play another match? yes or no ");
            playAgain = Console.ReadLine().ToLower();



            if (playAgain == "yes")
            {
                Console.WriteLine("Alrighty get ready for battle again");
                Rungame();
            }
            else if (playAgain == "no")
            {
                Console.WriteLine("We hate to see you go, come back soon");
                Console.WriteLine("press any key to exit");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Please select again");
                PLayAgain();
            }
        }
    }
}

   
