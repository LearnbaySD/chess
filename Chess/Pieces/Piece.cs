using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    interface Piece
    {
        string color { get; set; }
        int xPos { get; set; }
        int yPos { get; set; }
        bool move(int Dx, int Dy, Piece destPiece, Chessboard cb);
    }
}
