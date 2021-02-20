using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RandomPlayer : Player
    {
        public string Name { get; set; }

        public RandomPlayer()
        {
            Name = "Rando";
        }

        public override RPS GenerateRPS()
        {
            var random = new Random();
            RPS randomEnum = (RPS)random.Next(0, 3);

            return randomEnum;
        }
    }
}
