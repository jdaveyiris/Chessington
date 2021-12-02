using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square newPos;
            Square currentPos = board.FindPiece(this);
            var availablePos = new List<Square>();

            //needs cleaning up (refactoring).

                    if ((currentPos.Row + 1) < 8 && (currentPos.Col + 2) < 8)
                    {
                        newPos = Square.At(currentPos.Row + 1, currentPos.Col + 2);
                        availablePos.Add(newPos);
                    }
                    if ((currentPos.Row + 2) < 8 && (currentPos.Col + 1) < 8)
                    {
                        newPos = Square.At(currentPos.Row + 2, currentPos.Col + 1);
                        availablePos.Add(newPos);
                    }

                    if ((currentPos.Row + 1) < 8 && (currentPos.Col - 2) >= 0)
                    {
                        newPos = Square.At(currentPos.Row + 1, currentPos.Col - 2);
                        availablePos.Add(newPos);
                    }
                    if ((currentPos.Row + 2) < 8 && (currentPos.Col - 1) >= 0)
                    {
                        newPos = Square.At(currentPos.Row + 2, currentPos.Col - 1);
                        availablePos.Add(newPos);
                    }

                    if ((currentPos.Row - 1) >= 0 && (currentPos.Col + 2) < 8)
                    {
                        newPos = Square.At(currentPos.Row - 1, currentPos.Col + 2);
                        availablePos.Add(newPos);
                    }
                    if ((currentPos.Row - 2) >= 0 && (currentPos.Col + 1) < 8)
                    {
                        newPos = Square.At(currentPos.Row - 2, currentPos.Col + 1);
                        availablePos.Add(newPos);
                    }

                    if ((currentPos.Row - 1) >= 0 && (currentPos.Col - 2) >= 0)
                    {
                        newPos = Square.At(currentPos.Row - 1, currentPos.Col - 2);
                        availablePos.Add(newPos);
                    }
                    if ((currentPos.Row - 2) >= 0 && (currentPos.Col - 1) >= 0)
                    {
                        newPos = Square.At(currentPos.Row - 2, currentPos.Col - 1);
                        availablePos.Add(newPos);
                    }
              
            return availablePos;
        }
    }
}