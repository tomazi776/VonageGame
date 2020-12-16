using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VonageGame.Models
{
    public class SimplePiece : Piece
    {
        public SimplePiece(CurrentState defaultStartingState = null)
        {
            AssignDefaultState(defaultStartingState);
        }

        private void AssignDefaultState(CurrentState defaultStartingState)
        {
            if (defaultStartingState is null)
            {
                CurrentState = new CurrentState()
                {
                    Direction = Direction.North,
                    Location = new System.Drawing.Point(0, 0)
                };
            }
            else
            {
                CurrentState = defaultStartingState;
            }
        }

        public override CurrentState Move(Direction direction, int moveBy = 1)
        {

            //moved
            return new CurrentState()
            {
                //Direction = dirTranslatedFromInput,
                //Location = finalLocation
            };
        }
    }
}
