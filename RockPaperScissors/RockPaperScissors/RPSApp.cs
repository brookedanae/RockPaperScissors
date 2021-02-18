﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class RPSApp
    {
        public int HumanScore { get; set; } = 0;
        public int OpponentScore { get; set; } = 0;

        public void Play()
        {

            Console.WriteLine("Welcome the RPS Championships!");

            HumanPlayer human = new HumanPlayer();

            Console.Write("Enter your name: ");
            human.Name = Console.ReadLine();

            do
            {
                Player opponent = GetPlayer();

                RPS humanChoice = human.GenerateRPS();
                RPS playerChoice = opponent.GenerateRPS();

                Console.WriteLine($"Your chose: {humanChoice}");
                Console.WriteLine($"Opponent chose : {playerChoice}");

                if (humanChoice == RPS.Rock && playerChoice == RPS.Scissors)
                {
                    Console.WriteLine("You win!");
                    HumanScore++;
                }
                else if(humanChoice == RPS.Paper && playerChoice == RPS.Rock)
                {
                    Console.WriteLine("You win!");
                    HumanScore++;
                }
                else
                {
                    Console.WriteLine("You lose!");
                    OpponentScore++;
                }


                Console.WriteLine($"Your score: {HumanScore}");
                Console.WriteLine($"Opponent score: {OpponentScore}");

            } while (PlayAgain());
        }

        private bool PlayAgain()
        {
            string playAgain;

            bool isInvalid;
            do
            {
                Console.WriteLine("Would you like to play again? (y/n)");
                playAgain = Console.ReadLine().ToLower();

                isInvalid = playAgain != "y" && playAgain != "n";
                if (isInvalid)
                {
                    Console.WriteLine("Please enter a 'y' or 'n'!" + "\n");
                }
            } while (isInvalid);

            if(playAgain == "n")
            {
                Console.WriteLine("Goodbye");
            }

            return playAgain == "y";
        }

        private Player GetPlayer()
        {
            do
            {
                Console.WriteLine("Choose your opponent");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "rocky":
                        return new RockPlayer();
                    case "rando":
                        return new RandomPlayer();
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }

            } while (true);
        }
    }
}
