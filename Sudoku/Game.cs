using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
        public const int MIN_INIT_INDEX = 3;
        public const int ELIGIBLE_INDEX = 4;
        public const int MAX_INIT_INDEX = 5;
        
        private int[,] initialState;
        private int[,] field;
        private int[,] solution;
        private bool[,] correctnessTable;
        private int correctCells;

        public Game()
        {
            initialState = new int[FIELD_SIZE, FIELD_SIZE];
            field = new int[FIELD_SIZE, FIELD_SIZE];
            solution = new int[FIELD_SIZE, FIELD_SIZE];
            correctnessTable = new bool[FIELD_SIZE, FIELD_SIZE];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="difficulty">The higher value, the harder game. Zero is normal difficulty.</param>
        public void generateLevel(int difficulty)
        {
            //Подготовка
            Random randomizer = new Random();
            int[] seed = new int[9];

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
                    solution[reali, j] = seed[(j + i) % FIELD_SIZE];
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
                        buf = solution[a, j];
                        solution[a, j] = solution[b, j];
                        solution[b, j] = buf;
                    }

                street = randomizer.Next(BASE);
                a = street * BASE + randomizer.Next(BASE);
                b = street * BASE + randomizer.Next(BASE);
                if (a != b)
                    for (int j = 0; j < FIELD_SIZE; ++j)
                    {
                        buf = solution[j, a];
                        solution[j, a] = solution[j, b];
                        solution[j, b] = buf;
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
                            buf = solution[a * BASE + j, k];
                            solution[a * BASE + j, k] = solution[b * BASE + j, k];
                            solution[b * BASE + j, k] = buf;
                        }

                a = randomizer.Next(BASE);
                b = randomizer.Next(BASE);
                if (a != b)
                    for (int j = 0; j < BASE; ++j)
                        for (int k = 0; k < FIELD_SIZE; ++k)
                        {
                            buf = solution[k, a * BASE + j];
                            solution[k, a * BASE + j] = solution[k, b * BASE + j];
                            solution[k, b * BASE + j] = buf;
                        }
            }

            //Определение начального состояния
            Array.Clear(initialState, 0, initialState.Length);
            int[] columnVolumes = new int[FIELD_SIZE];
            int[,] boxVolumes = new int[BASE,BASE];
            for (int i = 0; i < FIELD_SIZE; ++i)
            {
                int rowIndex = 0;
                for (int j = 0; j < 3 && rowIndex != ELIGIBLE_INDEX; ++j)
                    rowIndex = randomizer.Next(MIN_INIT_INDEX, MAX_INIT_INDEX + 1) - difficulty;
                if (rowIndex < 1)
                    rowIndex = 1;
                else if (rowIndex > FIELD_SIZE - 1)
                    rowIndex = FIELD_SIZE - 1;
                do
                {
                    int attempts = 0;
                    bool success = false;
                    pos = randomizer.Next(FIELD_SIZE);
                    do
                    {
                        if (initialState[i, pos] == 0 && columnVolumes[pos] < MAX_INIT_INDEX - difficulty && boxVolumes[i / BASE, pos / BASE] < MAX_INIT_INDEX - difficulty)
                        {
                            initialState[i, pos] = solution[i, pos];
                            ++columnVolumes[pos];
                            ++boxVolumes[i / BASE, pos / BASE];
                            success = true;
                        }
                        else
                        {
                            pos = (pos + 1) % FIELD_SIZE;
                        }
                    } while (!success && attempts++ < FIELD_SIZE);
                } while (--rowIndex > 0);
            }
            setInitialState();
        }

        public List<Point> findRepetitionsInSubmatrix(int x1, int y1, int x2, int y2, int target, int xignore, int yignore)
        {
            List<Point> result = new List<Point>();
            for (int i = x1; i <= x2; ++i)
                for (int j = y1; j <= y2; ++j)
                    if (field[i, j] == target && !(i == xignore && j == yignore))
                        result.Add(new Point(i, j));
            return result;
        }

        public void setInitialState()
        {
            field = (int[,])initialState.Clone();
            correctCells = 0;
            for (int i = 0; i < FIELD_SIZE; ++i)
                for (int j = 0; j < FIELD_SIZE; ++j)
                    if (field[i, j] > 0)
                    {
                        correctnessTable[i, j] = true;
                        ++correctCells;
                    }
        }

        public int[,] InitialState
        {
            get {return initialState;}
        }

        public int[,] Field
        {
            get { return field; }
        }

        public int[,] Solution
        {
            get { return solution; }
        }

        public bool[,] CorrectnessTable
        {
            get { return correctnessTable; }
        }

        public int CorrectCells
        {
            get { return correctCells; }
            set { correctCells = value; }
        }
    }
}
