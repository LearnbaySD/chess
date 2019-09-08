using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Rook : Piece
    {
        bool everMoved { get; set; }
        public string color { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }
        public bool move(int Dx, int Dy, Piece destP, Chessboard cb)
        {
            //logic of validity of move goes here and capture
            //if valid return true;
            // else false;
            Console.WriteLine("Rook moves");
            cb.update(xPos, yPos, Dx, Dy);
            xPos = Dx;
            yPos = Dy;

            return true;
        }

        public bool isReadytoCastle()
        {
            return !everMoved;
        }
    }
}
