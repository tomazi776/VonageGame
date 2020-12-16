using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VonageGame.Models
{
    public class BoardGame
    {
        private const int nFields = 5;
        private const string emptyBoardField = "O";
        private const string occupiedBoardField = "X";
        public string[,] Board { get; set; }
        public List<Piece> Pieces { get; set; }
        public BoardGame()
        {
            Pieces = new List<Piece>();
        }

        public void MovePiece(Piece piece)
        {

        }

        public string[,] GenerateEmptyBoard(int nFields)
        {
            string[,] matrix = new string[nFields, nFields];
            for (int i = 0; i < nFields; i++)
            {
                for (int j = 0; j < nFields; j++)
                {
                    matrix[i, j] = "O";
                    PrintMatrix(nFields, matrix, i, j);
                }
            }
            return matrix;
        }

        private void PrintMatrix(int nFields, string[,] matrix, int i, int j)
        {
            Console.Write(matrix[i, j] + " ");
            if (j == nFields - 1)
            {
                Console.Write(Environment.NewLine);
            }
        }
    }
}
