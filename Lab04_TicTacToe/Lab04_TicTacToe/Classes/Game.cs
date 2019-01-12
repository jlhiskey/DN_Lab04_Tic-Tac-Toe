﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	class Game
	{
		public Player PlayerOne { get; set; }
		public Player PlayerTwo { get; set; }
		public Player Winner { get; set; }
		public Board Board { get; set; }


		/// <summary>
		/// Require 2 players and a board to start a game. 
		/// </summary>
		/// <param name="p1">Player 1</param>
		/// <param name="p2">Player 2</param>
		public Game(Player p1, Player p2)
		{
			PlayerOne = p1;
			PlayerTwo = p2;
			Board = new Board();
		}

		/// <summary>
		/// Activate the Play of the game
		/// </summary>
		/// <returns>Winner</returns>
		public Player Play()
		{

            //Done: Complete this method and utilize the rest of the class structure to play the game.

            // Total Avaliable Turns
            int totalTurns = 9;

            // Keep track of whos turn it is.
            Player currentPlayer = null;

            // Keep track of current turn count
            int currentTurn;

            // Turn Sequence
            for (currentTurn = 0; currentTurn < totalTurns; currentTurn++)
            {
                //Show Board
                Board.DisplayBoard();

                //Set Current Player
                currentPlayer = NextPlayer();

                //Current Player Takes Turn
                currentPlayer.TakeTurn(Board);

                //Check if Turn Caused Player to Win
                //If Yes End Game
                if (CheckForWinner(Board) == true) {
                    break;
                }
                //If No Switch to Other Player
                else
                {
                    SwitchPlayer();
                }

                
                
            }
            // Show the final board
            Board.DisplayBoard();

            //Return with who the current player is if the game hasn't ended. Else return nothing.
            if (currentTurn == totalTurns)
            {
                return null;
            }
            else
            {
                return currentPlayer;
            }

            
        }


		/// <summary>
		/// Check if winner exists
		/// </summary>
		/// <param name="board">current state of the board</param>
		/// <returns>if winner exists</returns>
		public bool CheckForWinner(Board board)
		{
			int[][] winners = new int[][]
			{
				new[] {1,2,3},
				new[] {4,5,6},
				new[] {7,8,9},

				new[] {1,4,7},
				new[] {2,5,8},
				new[] {3,6,9},

				new[] {1,5,9},
				new[] {3,5,7}
			};

			// Given all the winning conditions, Determine the winning logic. 
			for (int i = 0; i < winners.Length; i++)
			{
				Position p1 = Player.PositionForNumber(winners[i][0]);
				Position p2 = Player.PositionForNumber(winners[i][1]);
				Position p3 = Player.PositionForNumber(winners[i][2]);

				string a = Board.GameBoard[p1.Row, p1.Column];
				string b = Board.GameBoard[p2.Row, p2.Column];
				string c = Board.GameBoard[p3.Row, p3.Column];

				// DONE:  Determine a winner has been reached. 
                if (a == b && a == c)
                {
                    return true;
                }			
			
			}

			return false;
		}


		/// <summary>
		/// Determine next player
		/// </summary>
		/// <returns>next player</returns>
		public Player NextPlayer()
		{
			return (PlayerOne.IsTurn) ? PlayerOne : PlayerTwo;
		}

		/// <summary>
		/// End one players turn and activate the other
		/// </summary>
		public void SwitchPlayer()
		{
			if (PlayerOne.IsTurn)
			{
              
				PlayerOne.IsTurn = false;

              
				PlayerTwo.IsTurn = true;
			}
			else
			{
				PlayerOne.IsTurn = true;
				PlayerTwo.IsTurn = false;
			}
		}


	}
}
