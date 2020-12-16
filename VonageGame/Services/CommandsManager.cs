using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VonageGame.Models;

namespace VonageGame.Services
{
    public class CommandsManager
    {
        public string UserCommands { get; private set; }
        public CommandsManager(string commands)
        {
            UserCommands = commands;
        }

        public void TranslateCommandsToActionsForPiece(string commands, Piece piece)
        {
            var actionsArr = new Action[commands.Length];
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'M')
                {
                    actionsArr[i] = new SimplePiece().
                }
            }
        }
    }
}
