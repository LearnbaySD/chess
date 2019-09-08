using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class King : Piece
    {
        bool everMoved { get; set; }
        bool hasBeenChecked { get; set; }
        public string color { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }
        public bool move(int Dx, int Dy, Piece destP, Chessboard cb)
        {
            //logic of validity of move goes here and capture
            //if valid return true;
            // else false;
            Console.WriteLine("King moves");
            cb.update(xPos, yPos, Dx, Dy);
            xPos = Dx;
            yPos = Dy;

            return true;
        }

        public bool isReadytoCastle()
        {
            return !hasBeenChecked && !everMoved;
        }

        public bool castle(Rook rook, Chessboard cb)
        {
            if(isReadytoCastle() && rook.isReadytoCastle())
            {
                // check which rook
                cb.update(this.xPos, this.yPos, rook.xPos + 1, rook.yPos);
                cb.update(rook.xPos, rook.yPos, this.xPos - 1, this.yPos);
                return true;
            }
            return false ;
        }

    }
}
