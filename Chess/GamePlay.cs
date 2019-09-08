using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class GamePlay
    {
        Chessboard chessboard;
        Player WPlayer;
        Player BPlayer;
        bool isWhiteMove;
        public GamePlay()
        {
            chessboard = new Chessboard();
            WPlayer = new Player("Player1", "playerone", "4.2");
            BPlayer = new Player("Player2","playertwo","4.5");
            isWhiteMove = true;
        }

        public Player game()
        {
            while (!ischeckMated() && !isStaleMated())
            {
                if(isWhiteMove)
                {
                    Console.WriteLine("White Plays the move \n");
                } else
                {
                    Console.WriteLine("Black Plays the move \n");
                }
                int Sx, Sy, Dx, Dy;
                Sx = Convert.ToInt32(Console.ReadLine());
                Sy = Convert.ToInt32(Console.ReadLine());
                Dx = Convert.ToInt32(Console.ReadLine());
                Dy = Convert.ToInt32(Console.ReadLine());

                bool isValid = false;
                if (isWhiteMove)
                {
                    isValid = WPlayer.move(Dx, Dy, chessboard.getPiece(Sx, Sy), chessboard.getPiece(Dx, Dy), chessboard);
                } else
                {
                    isValid = WPlayer.move(Dx, Dy, chessboard.getPiece(Sx, Sy), chessboard.getPiece(Dx, Dy), chessboard);
                }
                if (isValid)
                {
                    isWhiteMove = !isWhiteMove;
                }
            }
            return isWhiteMove ? BPlayer : WPlayer;
        }

        bool ischeckMated()
        {
            //add the check mate logic.
            return false;
        }

        bool isStaleMated()
        {
            //add the stale mate logic.
            return false;
        }

    }
}
