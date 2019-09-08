using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay gp = new GamePlay();
            Player winner = gp.game();
        }
    }
}
