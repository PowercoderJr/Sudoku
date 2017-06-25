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
    public partial class Dial : Form
    {
        private int result;

        public Dial()
        {
            InitializeComponent();
            DesktopLocation = new Point(MousePosition.X - Width / 2, MousePosition.Y - Height / 2);
        }

        private void pick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            result = btn.Text[0] - '0';
            Close();
        }

        public int getResult()
        {
            return result;
        }
    }
}
