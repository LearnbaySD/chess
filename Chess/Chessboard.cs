using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Chessboard
    {
        Piece[,] Matrix;
        public Chessboard()
        {
            Matrix = new Piece[8,8];
            Matrix[0, 0] = new Rook
                                    {
                                        xPos = 0,
                                        yPos = 0,
                                        color = "white"
                                    };
        // Similarily for all other Pieces.
            
        }

        public Piece getPiece(int x, int y)
        {
            if(x>= 0 && x < 8 && y >= 0 &&  y < 8)
            {
                return Matrix[x, y];
            }
            return null;
        }

        public void update(int Sx, int Sy, int Dx, int Dy)
        {
            Piece p = Matrix[Sx, Sy];
            Matrix[Dx, Dy] = p;
            Matrix[Sx, Sy] = null;
        }


    }
}
