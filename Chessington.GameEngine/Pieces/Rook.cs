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


            if (Player == Player.White)
            {
                newPos = Square.At(currentPos.Row - 1, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row - 2, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row - 3, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row - 4, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row - 5, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row - 6, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row - 7, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row + 1, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row + 2, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row + 3, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row + 4, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row + 5, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row + 6, currentPos.Col);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row + 7, currentPos.Col);
                availablePos.Add(newPos);

                newPos = Square.At(currentPos.Row, currentPos.Col + 1);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col + 2);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col + 3);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col + 4);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col + 5);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col + 6);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col + 7);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col - 1);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col - 2);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col - 3);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col - 4);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col - 5);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col - 6);
                availablePos.Add(newPos);
                newPos = Square.At(currentPos.Row, currentPos.Col - 7);
                availablePos.Add(newPos);

                // Was trying to figure out how to pass a range through  ¯\_(ツ)_/¯
                //newPos = Square.At(currentPos.Row, currentPos.Col + Range(1,7));
                //availablePos.Add(newPos);
                //newPos = Square.At(currentPos.Row, currentPos.Col - Range(1,7));
                //availablePos.Add(newPos);
            }



            return availablePos;
        }

        private int Range(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}