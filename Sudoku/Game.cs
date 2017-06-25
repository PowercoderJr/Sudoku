using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class Game
    {
        public const int BASE = 3;
        public const int FIELD_SIZE = BASE * BASE;
        public const int SWAPS = 20;
        
        private int[,] field;

        public Game()
        {
            field = new int[FIELD_SIZE, FIELD_SIZE];
        }

        public void generateField()
        {
            //Подготовка
            Random randomizer = new Random();
            int[] seed = new int[9];
            for (int i = 0; i < FIELD_SIZE; ++i)
                seed[i] = 0;

            int pos;
            for (int i = 1; i <= FIELD_SIZE; ++i)
            {
                pos = randomizer.Next(FIELD_SIZE);
                while (seed[pos] != 0)
                    pos = (pos + 1) % FIELD_SIZE;
                seed[pos] = i;
            }

            //Заполнение
            for (int i = 0; i < FIELD_SIZE; ++i)
            {
                int reali = i * BASE % FIELD_SIZE + i * BASE / FIELD_SIZE;
                for (int j = 0; j < FIELD_SIZE; ++j)
                {
                    field[reali, j] = seed[(j + i) % FIELD_SIZE];
                }
            }

            //Перемешивание
            int street, a, b, buf;
            for (int i = 0; i < SWAPS; ++i)
            {
                street = randomizer.Next(BASE);
                a = street * BASE + randomizer.Next(BASE);
                b = street * BASE + randomizer.Next(BASE);
                if (a != b)
                    for (int j = 0; j < FIELD_SIZE; ++j)
                    {
                        buf = field[a, j];
                        field[a, j] = field[b, j];
                        field[b, j] = buf;
                    }

                street = randomizer.Next(BASE);
                a = street * BASE + randomizer.Next(BASE);
                b = street * BASE + randomizer.Next(BASE);
                if (a != b)
                    for (int j = 0; j < FIELD_SIZE; ++j)
                    {
                        buf = field[j, a];
                        field[j, a] = field[j, b];
                        field[j, b] = buf;
                    }
            }

            for (int i = 0; i < SWAPS/4; ++i)
            {
                a = randomizer.Next(BASE);
                b = randomizer.Next(BASE);
                if (a != b)
                    for (int j = 0; j < BASE; ++j)
                        for (int k = 0; k < FIELD_SIZE; ++k)
                        {
                            buf = field[a * 3 + j, k];
                            field[a * 3 + j, k] = field[b * 3 + j, k];
                            field[b * 3 + j, k] = buf;
                        }

                a = randomizer.Next(BASE);
                b = randomizer.Next(BASE);
                if (a != b)
                    for (int j = 0; j < BASE; ++j)
                        for (int k = 0; k < FIELD_SIZE; ++k)
                        {
                            buf = field[k, a * 3 + j];
                            field[k, a * 3 + j] = field[k, b * 3 + j];
                            field[k, b * 3 + j] = buf;
                        }
            }
        }

        public int[,] getField()
        {
            return field;
        }
    }
}
