﻿using System.Collections.Generic;
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

            Square newPos;

            Square currentPos = board.FindPiece(this);
            //'this' is referring to the current Pawn selected?
            var availablePos = new List<Square>();

            if (Player == Player.White)
            {
                newPos = Square.At(currentPos.Row - 1, currentPos.Col);

                availablePos.Add(newPos);
            }

            if (Player == Player.Black)
            {
                newPos = Square.At(currentPos.Row + 1, currentPos.Col);

                availablePos.Add(newPos);
            }

            return availablePos;
        }
    }
}