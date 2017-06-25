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
        private Game game;
        private Cell[,] cells;

        public Main()
        {
            InitializeComponent();

            cells = new Cell[Game.FIELD_SIZE, Game.FIELD_SIZE];
            for (int i = 0; i < Game.FIELD_SIZE; ++i)
                for (int j = 0; j < Game.FIELD_SIZE; ++j)
                {
                    cells[j, i] = new Cell();
                    cells[j, i].Click += onCellClicked;
                    grid.Controls.Add(cells[j, i], j, i);
                }

            game = new Game();
            restart();
        }

        private void onCellClicked(object sender, EventArgs e)
        {
            Label cell = sender as Label;
            switch ((e as MouseEventArgs).Button)
            {
                case MouseButtons.Left:
                    Dial f = new Dial();
                    f.ShowDialog();
                    game.getField()[grid.GetRow(cell), grid.GetColumn(cell)] = f.getResult();
                    cell.Text = f.getResult().ToString();
                    break;
                case MouseButtons.Right:
                    game.getField()[grid.GetRow(cell), grid.GetColumn(cell)] = 0;
                    cell.Text = "";
                    break;
            }

        }

        private void restart()
        {
            game.generateField();
            int[,] temp = game.getField();
            for (int i = 0; i < Game.FIELD_SIZE; ++i)
                for (int j = 0; j < Game.FIELD_SIZE; ++j)
                    cells[j, i].Text = temp[i, j].ToString();
        }

        private void начатьСначалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restart();
        }
    }
}
