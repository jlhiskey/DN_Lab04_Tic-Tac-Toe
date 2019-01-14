using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing Area
            StartGame();

            Console.ReadLine();
        }

        /// <summary>
        /// Starts Game
        /// </summary>
        static void StartGame()
        {
            Console.WriteLine("Welcome to Jason's Tic-Tac-Toe");

            //Determine Players (Player)
            Player playerOne = new Player();
            Player playerTwo = new Player();

            //P1
            Console.WriteLine("What is Player One's Name?");
            playerOne.Name = Console.ReadLine();
            if(playerOne.Name.Length == 0)
            {
                playerOne.Name = "Player One";
            }
            playerOne.Marker = "X";
            playerOne.IsTurn = true;

            //P2
            Console.WriteLine("What is Player Two's Name?");
            playerTwo.Name = Console.ReadLine();
            if (playerTwo.Name.Length == 0)
            {
                playerTwo.Name = "Player Two";
            }
            playerTwo.Marker = "O";
            playerTwo.IsTurn = true;

            // Start new Game (Game)
            Game game = new Game(playerOne, playerTwo);

            Player winnerOfGame = game.Play();

            // Display Winner
            Console.WriteLine();
            if (winnerOfGame != null)
            {
                Console.WriteLine($"Great Job {winnerOfGame.Name}!!");
            }
            else
            {
                Console.WriteLine("DRAW!!!");
            }
            Console.WriteLine();
            Console.WriteLine($"Would you like to play again?");
            int confirm = 0;
            Console.WriteLine("Press 1 for YES");
            Console.WriteLine("Press 2 for NO");
            try
            {
                confirm = int.Parse(Console.ReadLine());
                if (confirm > 2 || confirm < 1)
                {
                    Console.WriteLine($"Please enter Integer.");
                    Console.WriteLine("Press 1 for YES");
                    Console.WriteLine("Press 2 for NO");
                    confirm = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter Integer.");
                Console.WriteLine("Press 1 for YES");
                Console.WriteLine("Press 2 for NO");
                confirm = int.Parse(Console.ReadLine());
            }
            if (confirm == 1)
            {
                StartGame();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
