using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Cell
    {
        private int number;
        private Color color;
        private bool isColorChanged;

        public Cell()
        {
            number = 0;
            color = Color.Black;
            isColorChanged = false;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool IsColorChanged
        {
            get { return isColorChanged; }
            set { isColorChanged = value; }
        }
    }
}
