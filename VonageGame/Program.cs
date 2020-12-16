using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VonageGame.Models;
using VonageGame.Services;

namespace VonageGame
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardGame boardGame = new BoardGame();
            boardGame.Pieces.Add(new SimplePiece());

            var inputCommands = Console.ReadLine();

            CommandsManager cmdManager = new CommandsManager(inputCommands);
            cmdManager.TranslateCommandsToActionsForPiece()
            //var board = boardGame.GenerateEmptyBoard(5);
            
        }
    }
}
