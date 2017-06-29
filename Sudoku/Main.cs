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
        private Label[,] cells;

        public Main()
        {
            InitializeComponent();

            cells = new Label[Game.FIELD_SIZE, Game.FIELD_SIZE];
            for (int i = 0; i < Game.FIELD_SIZE; ++i)
                for (int j = 0; j < Game.FIELD_SIZE; ++j)
                {
                    Label cell = new Label();
                    cell.Font = new Font(new FontFamily("Courier New"), 36, FontStyle.Bold);
                    cell.AutoSize = false;
                    cell.Dock = DockStyle.Fill;
                    cell.TextAlign = ContentAlignment.MiddleCenter;
                    cell.BackColor = Color.Transparent;
                    cell.ForeColor = Color.Black;
                    cell.Click += onCellClicked;
                    cells[i, j] = cell;
                    grid.Controls.Add(cell, j, i);
                }

            game = new Game();
            restart();
        }

        private void onCellClicked(object sender, EventArgs e)
        {
            Label cell = sender as Label;
            int i = grid.GetRow(cell), j = grid.GetColumn(cell);
            int[,] field = game.getField();
            if (game.getInitialState()[i, j] == 0)
            {
                int oldValue = field[i, j];
                field[i, j] = 0;
                updateColors(i, j, oldValue, true);

                switch ((e as MouseEventArgs).Button)
                {
                    case MouseButtons.Left:
                        int digit;
                        if (подсказкаToolStripMenuItem.Checked)
                        {
                            digit = game.getSolution()[i, j];
                            подсказкаToolStripMenuItem.Checked = false;
                        }
                        else
                        {
                            Dial f = new Dial();
                            f.ShowDialog();
                            digit = f.getResult();
                        }
                        field[i, j] = digit;
                        cell.Text = digit.ToString();
                        break;
                    case MouseButtons.Right:
                        field[i, j] = 0;
                        cell.Text = "";
                        break;
                }
                updateColors(i, j, 0, true);
            }
        }

        private void restart()
        {
            game.generateLevel();
            fillCells();
        }

        private void clear()
        {
            game.setInitialState();
            fillCells();
        }

        private void fillCells()
        {
            int[,] field = game.getField();
            int[,] initialState = game.getInitialState();
            for (int i = 0; i < Game.FIELD_SIZE; ++i)
                for (int j = 0; j < Game.FIELD_SIZE; ++j)
                {
                    cells[i, j].Text = field[i, j] == 0 ? "" : field[i, j].ToString();
                    if (initialState[i, j] > 0)
                        cells[i, j].ForeColor = Color.DarkGreen;
                    else
                        cells[i, j].ForeColor = Color.Black;

                }
        }

        private void updateColors(int i, int j, int oldValue, bool recursive)
        {
            Label target = cells[i, j];
            int[,] field = game.getField();
            int value = oldValue > 0 ? oldValue : field[i, j];
            int boxi = i / Game.BASE, boxj = j / Game.BASE;

            if (value > 0)
            {
                List<Point> repetitions = game.findRepetitionsInSubmatrix(i, 0, i, Game.FIELD_SIZE - 1, value, i, j);
                repetitions.AddRange(game.findRepetitionsInSubmatrix(0, j, Game.FIELD_SIZE - 1, j, value, i, j));
                repetitions.AddRange(game.findRepetitionsInSubmatrix(boxi * Game.BASE, boxj * Game.BASE,
                    boxi * Game.BASE + Game.BASE - 1, boxj * Game.BASE + Game.BASE - 1, value, i, j));

                if (target.ForeColor != Color.DarkGreen)
                    if (repetitions.Count == 0)
                        target.ForeColor = Color.Black;
                    else
                        target.ForeColor = Color.DarkRed;

                if (recursive)
                    for (int k = 0; k < repetitions.Count; ++k)
                        updateColors(repetitions[k].X, repetitions[k].Y, oldValue, false);
            }
        }

        private void создатьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void начатьСначалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void подсказкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}