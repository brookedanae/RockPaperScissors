using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    abstract class Player
    {
        private string Name { get; set; }

        public Player(string _name)
        {
            Name = _name;
        }

        public Player()
        {

        }


        public abstract RPS GenerateRPS();
        //{

        //}
    }


}
