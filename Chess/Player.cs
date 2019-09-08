using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Player
    {
        string name;
        string id;
        string rating;

        public Player(string _name, string _id, string _rating)
        {
            name = _name;
            id = _id;
            rating = _rating;
        }

        public bool move(int Dx, int Dy, Piece p, Piece captureOrCastlePiece, Chessboard cb)
        {
            return p.move(Dx, Dy, captureOrCastlePiece, cb);
            
        }
    }
}
