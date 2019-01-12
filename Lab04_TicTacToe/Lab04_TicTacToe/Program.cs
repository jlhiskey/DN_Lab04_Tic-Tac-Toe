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
        }
    }
}
