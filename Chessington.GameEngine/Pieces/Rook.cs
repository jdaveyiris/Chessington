using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square newPos;
            Square currentPos = board.FindPiece(this);
            var availablePos = new List<Square>();

            for (int i = -7; i < 8; i++)
            {
                if (i != 0)
                {
                    newPos = Square.At(currentPos.Row + i, currentPos.Col);
                    availablePos.Add(newPos);
                    newPos = Square.At(currentPos.Row, currentPos.Col + i);
                    availablePos.Add(newPos);
                }
            }
       
            return availablePos;
        }

    }
}