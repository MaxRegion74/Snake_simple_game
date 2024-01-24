using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class Gameover
    {
        public void Game()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 20);
            Console.WriteLine("GAME OVER");
        }
    }
}
