using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RockPlayer : Player
    {
        public string Name { get; set; }

        public RockPlayer()
        {
            Name = "Rocky";
        }

        public override RPS GenerateRPS()
        {
            return RPS.Rock;
        }
    }
}
