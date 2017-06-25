using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Game
    {
        private int[,] field;

        public Game()
        {
            field = new int[Main.FIELD_SIZE, Main.FIELD_SIZE];
        }
    }
}
