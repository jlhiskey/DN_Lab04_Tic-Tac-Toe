using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToeTest
{
    public class GameTest
    {
        [Fact]
        public void GivenABoardTestForWinRow()
        {
            //Sets the Game Board Selected Positions
            Position positionOne = new Position(0, 0);
            Position positionTwo = new Position(0, 1);
            Position positionThree = new Position(0, 2);

            // Sets the Players of the Game
            Player player1 = new Player();
            Player player2 = new Player();

            //Initiates a new game
            Game testGame = new Game(player1, player2);

            //Marks Game Board Selected Positions
            testGame.Board.GameBoard[positionOne.Row, positionOne.Column] = "X";
            testGame.Board.GameBoard[positionTwo.Row, positionTwo.Column] = "X";
            testGame.Board.GameBoard[positionThree.Row, positionThree.Column] = "X";

            Assert.True(testGame.CheckForWinner(testGame.Board));
        }

        [Fact]
        public void GivenABoardTestForWinColumn()
        {

        }

        [Fact]
        public void GivenABoardTestForWinDiag()
        {

        }

        [Fact]
        public void GivenABoardTestForNoWin()
        {

        }

        [Fact]
        public void PlayersSwitchBetweenTurnsTest()
        {

        }

        [Fact]
        public void InputPostionEqualsCorrectBoardPosition()
        {

        }

      
    }
}
