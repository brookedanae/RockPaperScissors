using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class HumanPlayer : Player
    {
        public string Name { get; set; }

        public HumanPlayer(string _name) : base (_name)
        {
            Name = _name;
        }

        public HumanPlayer()
        {

        }

        public override RPS GenerateRPS()
        {
            string userChoice;

            while (true)
            {
                Console.WriteLine($"Thanks, {Name}! Now, rock, paper, or scissors? (r/p/s)");
                userChoice = Console.ReadLine();


                switch (userChoice)
                {
                    case "r":
                        return RPS.Rock;
                    case "rock":
                        return RPS.Rock;
                    case "s":
                        return RPS.Scissors;
                    case "scissors":
                        return RPS.Scissors;
                    case "p":
                        return RPS.Paper;
                    case "paper":
                        return RPS.Paper;
                    default:
                        Console.WriteLine("Please enter a valid option!");
                        break;
                }
            }
        }
    }
}
