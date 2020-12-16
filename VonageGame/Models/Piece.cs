using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VonageGame.Models
{
    public abstract class Piece
    {
        public List<Move> Moves { get; set; }
        public CurrentState CurrentState { get; set; }
        public abstract CurrentState Move(Direction direction, int moveBy = 1);
    }
}
