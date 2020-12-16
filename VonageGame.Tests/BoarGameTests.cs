using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VonageGame.Tests
{
    public class BoarGameTests
    {
        [Fact]
        public void GenerateEmptyBoard_ShouldCreateWithSize()
        {
            //Arrange
            int arrLength = 5;
            int expectedMatrixSize = arrLength * arrLength;

            //Act
            BoardGame boardgame = new BoardGame();            
            string[,] actualMatrix = boardgame.GenerateEmptyBoard(5);
            int actualMatrixSize = actualMatrix.Length;

            //Assert
            Assert.Equal(expectedMatrixSize, actualMatrixSize);
        }
    }
}
