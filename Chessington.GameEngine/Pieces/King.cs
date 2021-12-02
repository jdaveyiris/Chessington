using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square newPos;
            Square currentPos = board.FindPiece(this);
            var availablePos = new List<Square>();

            for (int i = -1; i < 2; i++)
            {
                if (i != 0)
                {
                    // diag  up
                    if ((currentPos.Row + i) < 8 && (currentPos.Col + i) < 8)
                    {
                        newPos = Square.At(currentPos.Row + i, currentPos.Col + i);
                        availablePos.Add(newPos);
                    }
                    //diag  down
                    if ((currentPos.Row + i) < 8 && (currentPos.Col - i) >= 0)
                    {
                        newPos = Square.At(currentPos.Row + i, currentPos.Col - i);
                        availablePos.Add(newPos);
                    }
                   
                    // left and right
                    if (currentPos.Row + i >= 0 && (currentPos.Row + i) < 8)
                    {
                        newPos = Square.At(currentPos.Row + i, currentPos.Col);
                        availablePos.Add(newPos);
                    }
                    //up and down
                    if (currentPos.Col + i >= 0 && (currentPos.Col + i) < 8)
                    {
                        newPos = Square.At(currentPos.Row, currentPos.Col + i);
                        availablePos.Add(newPos);
                    }
                }
            }
            return availablePos;
        }
    }
}