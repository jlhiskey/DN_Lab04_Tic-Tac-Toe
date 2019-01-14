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
            //Sets the Game Board Selected Positions
            Position positionOne = new Position(0, 0);
            Position positionTwo = new Position(1, 0);
            Position positionThree = new Position(2, 0);

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
        public void GivenABoardTestForWinDiag()
        {
            //Sets the Game Board Selected Positions
            Position positionOne = new Position(0, 0);
            Position positionTwo = new Position(1, 1);
            Position positionThree = new Position(2, 2);

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
        public void GivenABoardTestForNoWin()
        {
            //Sets the Game Board Selected Positions
            Position positionOne = new Position(0, 0);
            Position positionTwo = new Position(1, 2);
            Position positionThree = new Position(2, 2);

            // Sets the Players of the Game
            Player player1 = new Player();
            Player player2 = new Player();

            //Initiates a new game
            Game testGame = new Game(player1, player2);

            //Marks Game Board Selected Positions
            testGame.Board.GameBoard[positionOne.Row, positionOne.Column] = "X";
            testGame.Board.GameBoard[positionTwo.Row, positionTwo.Column] = "X";
            testGame.Board.GameBoard[positionThree.Row, positionThree.Column] = "X";

            Assert.False(testGame.CheckForWinner(testGame.Board));
        }

        [Fact]
        public void PlayersSwitchBetweenTurnsTest()
        {
            // Sets the Players of the Game
            Player player1 = new Player();
            player1.Name = "Ricky Bobby";

            Player player2 = new Player();
            player2.Name = "Jim Bob";

            //Initiates a new game
            Game testGame = new Game(player1, player2);

            //Sets player of first turn.
            Player playerTurnOne = testGame.NextPlayer();

            //Switches Player
            testGame.SwitchPlayer();

            //Sets player of second turn.
            Player playerTurnTwo = testGame.NextPlayer();

            Assert.NotEqual(playerTurnOne, playerTurnTwo);
        }

        [Fact]
        public void InputPostionEqualsCorrectBoardPosition()
        {
            //Sets input variable that would have come from user.
            int boardPosition = 9;

            //Parses input into the players turn instance
            Position positionCoordinates = Player.PositionForNumber(boardPosition);

            Assert.True(positionCoordinates.Row == 2 && positionCoordinates.Column == 2);
        }

        [Fact]
        public void InputPostionEqualsCorrectBoardPositionTwo()
        {
            //Sets input variable that would have come from user.
            int boardPosition = 5;

            //Parses input into the players turn instance
            Position positionCoordinates = Player.PositionForNumber(boardPosition);

            Assert.True(positionCoordinates.Row == 1 && positionCoordinates.Column == 1);
        }

        [Fact]
        public void InputPostionEqualsOutOfBoundsBoardPosition()
        {
            //Sets input variable that would have come from user.
            int boardPosition = 25;

            //Parses input into the players turn instance
            Position positionCoordinates = Player.PositionForNumber(boardPosition);

            Assert.Null(positionCoordinates);
        }
    }
}
