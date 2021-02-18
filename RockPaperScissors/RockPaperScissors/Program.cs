using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSApp rpsApp = new RPSApp();
            rpsApp.Play();

            //HumanPlayer newPlayer = new HumanPlayer();
            //Console.WriteLine(newPlayer.EnterUserName());

            HumanPlayer human = new HumanPlayer();
            //RPS newGame = human.GenerateRPS();
            //Console.WriteLine(newGame); 

           



            //Console.WriteLine("Thanks for playing! See ya!");
        }

        //public static string GetUserInput()
        //{
        //    bool isInvalid;
        //    do
        //    {
        //        Console.WriteLine("Welcome to Rock, Paper, Scissors!" + "\n");
        //        Console.Write("Enter your name: ");
        //        var userName = Console.ReadLine();

        //        Console.Write($"Thanks, {userName}! Would you like to play against The Jets or The Sharks? (j/s) ");
        //        var userOpponentChoice = Console.ReadLine().ToLower();
        //        isInvalid = userOpponentChoice != "j" && userOpponentChoice != "s";
        //        if (isInvalid)
        //        {
        //            Console.WriteLine("Please enter a valid opponent!");
        //        }
        //    } while (isInvalid);

        //    return "";

        //}
    }
}
