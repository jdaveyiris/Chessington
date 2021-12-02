using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            // set of rules to allow pawn to move 
            // find piece, show where it can move to, return that info to the board to be displayed
            // movement itself not included here
            // must admit I did use your code shown this morning to make this. 
            //----------
            //Red-02 must check if pawn has left its initial position, if no then it can move 1 or 2,
            //if not in initial position can only move 1.

            Square newPos;

            Square currentPos = board.FindPiece(this);
            var availablePos = new List<Square>();
            
            if (Player == Player.White && currentPos.Row == 6)
            {
                newPos = Square.At(currentPos.Row - 2, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row - 1, currentPos.Col);
                availablePos.Add(newPos);
            }

            if (Player == Player.White && currentPos.Row != 6)
            {
                newPos = Square.At(currentPos.Row - 1, currentPos.Col);
                availablePos.Add(newPos);
            }

            if (Player == Player.Black && currentPos.Row == 1)
            {
                newPos = Square.At(currentPos.Row + 2, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row + 1, currentPos.Col);
                availablePos.Add(newPos);
            }

            if (Player == Player.Black && currentPos.Row != 1)
            {
                newPos = Square.At(currentPos.Row + 1, currentPos.Col);
                availablePos.Add(newPos);
            }

            return availablePos;
        }
    }
}