using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Main : Form
    {
        public const int FIELD_SIZE = 9;

        private Game game;

        public Main()
        {
            InitializeComponent();
            for (int i = 0; i < FIELD_SIZE; ++i)
                for (int j = 0; j < FIELD_SIZE; ++j)
                {
                    Cell newCell = new Cell();
                    grid.Controls.Add(newCell, j, i);
                }
        }
    }
}
