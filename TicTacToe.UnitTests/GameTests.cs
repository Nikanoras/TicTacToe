using Xunit;

namespace TicTacToe.UnitTests
{
    public class GameTests
    {
        /// <summary>
        /// x o 
        /// x   o
        /// x o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenFirstPlayerFillsFirstColumn_ShouldReturnFirstPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "x", "o", "" };
            var secondRow = new[] { "x", "", "o" };
            var thirdRow = new[] { "x", "o", "" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("first player", winner);
        }

        /// <summary>
        /// o x 
        /// o x o
        ///   x
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenFirstPlayerFillsSecondColumn_ShouldReturnFirstPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "o", "x", "" };
            var secondRow = new[] { "o", "x", "o" };
            var thirdRow = new[] { "", "x", "" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("first player", winner);
        }

        /// <summary>
        /// o   x
        ///   o x
        ///   o x
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenFirstPlayerFillsThirdColumn_ShouldReturnFirstPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "o", "", "x" };
            var secondRow = new[] { "", "o", "x" };
            var thirdRow = new[] { "", "o", "x" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("first player", winner);
        }

        /// <summary>
        /// o x 
        /// o   x
        /// o x
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenSecondPlayerFillsFirstColumnShouldReturnSecondPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "o", "x", "" };
            var secondRow = new[] { "o", "", "x" };
            var thirdRow = new[] { "o", "x", "" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("second player", winner);
        }

        /// <summary>
        /// x o 
        /// x o x
        ///   o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenSecondPlayerFillsSecondColumn_ShouldReturnSecondPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "x", "o", "" };
            var secondRow = new[] { "x", "o", "x" };
            var thirdRow = new[] { "", "o", "" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("second player", winner);
        }

        /// <summary>
        /// x   o
        ///   x o
        ///   x o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenSecondPlayerFillsThirdColumn_ShouldReturnSecondPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "x", "", "o" };
            var secondRow = new[] { "", "x", "o" };
            var thirdRow = new[] { "", "x", "o" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("second player", winner);
        }

        /// <summary>
        /// x x x
        /// o   o
        ///   o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenFirstPlayerFillsFirstRow_ShouldReturnFirstPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "x", "x", "x" };
            var secondRow = new[] { "o", "", "o" };
            var thirdRow = new[] { "", "o", "" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("first player", winner);
        }

        /// <summary>
        ///   o o
        /// x x x
        ///   o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenFirstPlayerFillsSecondRow_ShouldReturnFirstPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "x", "o", "o" };
            var secondRow = new[] { "x", "x", "x" };
            var thirdRow = new[] { "", "o", "" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("first player", winner);
        }

        /// <summary>
        ///   o  
        /// o   o
        /// x x x
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenFirstPlayerFillsThirdRow_ShouldReturnFirstPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "", "o", "" };
            var secondRow = new[] { "o", "", "o" };
            var thirdRow = new[] { "x", "x", "x" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("first player", winner);
        }

        /// <summary>
        /// o o o
        /// x   x
        ///   x
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenSecondPlayerFillsFirstRow_ShouldReturnSecondPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "o", "o", "o" };
            var secondRow = new[] { "x", "", "x" };
            var thirdRow = new[] { "", "x", "" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("second player", winner);
        }

        /// <summary>
        ///   x x
        /// o o o
        ///   x
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenSecondPlayerFillsSecondRow_ShouldReturnSecondPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "", "x", "x" };
            var secondRow = new[] { "o", "o", "o" };
            var thirdRow = new[] { "", "x", "" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("second player", winner);
        }

        /// <summary>
        ///   x  
        /// x   x
        /// o o o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenSecondPlayerFillsThirdRow_ShouldReturnSecondPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "", "x", "" };
            var secondRow = new[] { "x", "", "x" };
            var thirdRow = new[] { "o", "o", "o" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("second player", winner);
        }

        /// <summary>
        /// x o o
        ///   x o
        ///     x
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenFirstPlayerFillsAcrossFromUpperLeftToBottomRight_ShouldReturnFirstPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "x", "o", "o" };
            var secondRow = new[] { "", "x", "o" };
            var thirdRow = new[] { "", "", "x" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("first player", winner);
        }

        /// <summary>
        /// o x x
        ///   o 
        /// x   o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenSecondlayerFillsAcrossFromUpperLeftToBottomRight_ShouldReturnSecondPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "o", "x", "x" };
            var secondRow = new[] { "", "o", "" };
            var thirdRow = new[] { "x", "", "o" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("second player", winner);
        }

        /// <summary>
        /// o   x
        ///   x o
        /// x   o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenFirstPlayerFillsAcrossFromUpperRightToBottomLeft_ShouldReturnFirstPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "o", "", "x" };
            var secondRow = new[] { "", "x", "o" };
            var thirdRow = new[] { "x", "", "o" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("first player", winner);
        }

        /// <summary>
        /// x   o
        ///   o x
        /// o   x
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenSecondPlayerFillsAcrossFromUpperRightToBottomLeft_ShouldReturnSecondPlayerAsWinner()
        {
            var game = new Game();
            var firstRow = new[] { "x", "", "o" };
            var secondRow = new[] { "", "o", "x" };
            var thirdRow = new[] { "o", "", "x" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal("second player", winner);
        }

        /// <summary>
        /// x x o
        /// o x x
        /// x o o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenNoWinner_ShouldReturnEmptyString()
        {
            var game = new Game();
            var firstRow = new[] { "x", "x", "o" };
            var secondRow = new[] { "o", "x", "x" };
            var thirdRow = new[] { "x", "o", "o" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal(string.Empty, winner);
        }

        /// <summary>
        ///     
        /// o x o
        /// x x o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenColumnIsEmptyStrings_ShouldReturnEmptyString()
        {
            var game = new Game();
            var firstRow = new[] { "", "", "" };
            var secondRow = new[] { "o", "x", "o" };
            var thirdRow = new[] { "x", "x", "o" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal(string.Empty, winner);
        }

        /// <summary>
        /// x   x
        /// o o  
        ///   x o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenColumnRowIsEmptyStrings_ShouldReturnEmptyString()
        {
            var game = new Game();
            var firstRow = new[] { "", "x", "x" };
            var secondRow = new[] { "", "o", "o" };
            var thirdRow = new[] { "", "x", "o" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal(string.Empty, winner);
        }

        /// <summary>
        /// x o 
        /// o   x
        ///   x o
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenAcrossFromUpperRightToBottomLeftIsEmptyStrings_ShouldReturnEmptyString()
        {
            var game = new Game();
            var firstRow = new[] { "x", "o", "" };
            var secondRow = new[] { "o", "", "x" };
            var thirdRow = new[] { "", "x", "o" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal(string.Empty, winner);
        }

        /// <summary>
        ///   o x
        /// o   x
        /// o x  
        /// </summary>
        [Fact]
        public void DetermineWinner_WhenAcrossFromBottomRightToUpperLeftIsEmptyStrings_ShouldReturnEmptyString()
        {
            var game = new Game();
            var firstRow = new[] { "x", "o", "" };
            var secondRow = new[] { "o", "", "x" };
            var thirdRow = new[] { "", "x", "o" };

            var result = new[] { firstRow, secondRow, thirdRow };
            string winner = game.DetermineWinner(result);

            Assert.Equal(string.Empty, winner);
        }
    }
}
