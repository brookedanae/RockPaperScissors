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

        //public string EnterUserName()
        //{
        //    //Console.Write("Enter your name: ");
        //    //var enterName = Console.ReadLine();
        //    //return $"Thanks, {enterName}";
        //    //return "";
        //}
        public override RPS GenerateRPS()
        {
            string userChoice;

            while (true)
            {
                Console.WriteLine($"Thanks, {Name}! Now, rock, paper, or scissors? (r/p/s)");
                userChoice = Console.ReadLine();
                //isInvalid = userChoice != "r" && userChoice != "p" && userChoice != "s";
                //if (isInvalid)
                //{
                //    Console.WriteLine("Please enter a valid choice!");
                //}



                switch (userChoice)
                {
                    case "r":
                        return RPS.Rock;
                    case "rock":
                        return RPS.Rock;
                    case "s":
                        return RPS.Scissors;
                    case "p":
                        return RPS.Paper;
                    default:
                        Console.WriteLine("Please enter a valid option!");
                        break;
                }
            }





            //if (userChoice == "r")
            //{
            //    Console.WriteLine(RPS.Rock);
            //}
            //else if (userChoice == "p")
            //{
            //    Console.WriteLine(RPS.Paper);
            //}
            //else if (userChoice =="s")
            //{
            //    Console.WriteLine(RPS.Scissors);
            //}



        }
    }
}
