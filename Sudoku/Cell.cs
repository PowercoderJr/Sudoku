using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class Cell : Label
    {
        public Cell() : base()
        {
            Font = new Font(new FontFamily("Courier New"), 36, FontStyle.Bold);
            AutoSize = false;
            Dock = DockStyle.Fill;
            TextAlign = ContentAlignment.MiddleCenter;
            Click += onClick;
        }

        public Cell(char character) : this()
        {
            Text = character.ToString();
        }

        private void onClick(object sender, EventArgs e)
        {
            Label cell = sender as Label;
            Dial f = new Dial();
            f.ShowDialog();
            cell.Text = f.getResult().ToString();
        }
    }
}
