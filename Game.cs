using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Game
    {
        /// <summary>
        /// Метод проверяет свободна ли выбранная клетка и соседние
        /// </summary>
        public static bool Check1(int[,] a) //
        {
            int count = 0;
            int lenA = a.GetLength(0);
            int lenB = a.GetLength(1);
            for (int i = 0; i < lenA; i++)
            {
                for (int j = 0; j < lenB; j++)
                {
                    if (a[i, j] != 0)
                    {
                        count++;
                    }
                }
            }
            if (count != 6)
            {
                return false;
            }
            for (int i = 0; i < lenA - 1; i++)
            {
                for (int j = 0; j < lenB - 1; j++)
                {
                    if (a[i, j] != 0)
                    {
                        if (a[i, j + 1] != 0 && a[i, j + 1] != a[i, j])
                        {
                            return false;
                        }
                        if (a[i + 1, j] != 0 && a[i + 1, j] != a[i, j])
                        {
                            return false;
                        }
                        if (a[i + 1, j + 1] != 0)
                        {
                            return false;
                        }
                    }
                }

            }
            for (int i = 0; i < lenA; i++)
            {
                for (int j = 0; j < lenA; j++)
                {
                    if (a[i, j] == 2 || a[i, j] == 3)
                    {
                        int sheep = a[i, j];
                        if (i == 0 && j != 0 && j != 4)
                        {
                            if (sheep != a[0, j - 1] && sheep != a[0, j + 1] && sheep != a[1, j])
                            {
                                return false;
                            }
                        }
                        if (i == 4 && j != 0 && j != 4)
                        {
                            if (sheep != a[4, j - 1] && sheep != a[4, j + 1] && sheep != a[3, j])
                            {
                                return false;
                            }
                        }
                        if (j == 0 && i != 0 && i != 4)
                        {
                            if (sheep != a[i - 1, 0] && sheep != a[i + 1, 0] && sheep != a[i, 1])
                            {
                                return false;
                            }
                        }
                        if (j == 4 && i != 0 && i != 4)
                        {
                            if (sheep != a[i - 1, 4] && sheep != a[i + 1, 4] && sheep != a[i, 3])
                            {
                                return false;
                            }
                        }
                        if (i > 0 && j > 0 && i < 4 && j < 4)
                        {
                            if (sheep != a[i - 1, j] && sheep != a[i + 1, j] && sheep != a[i, j + 1] && sheep != a[i, j - 1])
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        private int MakeShipPosition()
        {
            Random rnd = new Random();
            return rnd.Next(1, 2);
        }
        public static void Make3Ship(int[,] a)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 4);
            int y = rnd.Next(0, 4);
            if (y == 0)
            {
                a[x, y] = 3;
                a[x, y + 1] = 3;
                a[x, y + 2] = 3;
            }
            else if (y == 4)
            {
                a[x, y] = 3;
                a[x, y - 1] = 3;
                a[x, y - 2] = 3;
            }
            else if (x == 0)
            {
                a[x, y] = 3;
                a[x + 1, y] = 3;
                a[x + 2, y] = 3;
            }
            else if (x == 4)
            {
                a[x, y] = 3;
                a[x - 1, y] = 3;
                a[x - 2, y] = 3;
            }
            else
            {
                a[x, y] = 3;
                a[x + 1, y] = 3;
                a[x - 1, y] = 3;
            }
        }
        public static void Make2Ship(int[,] a)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 4);
            int y = rnd.Next(0, 4);
            while (a[x, y] != 0)
            {
                x = rnd.Next(0, 4);
                y = rnd.Next(0, 4);
            }
            if (y == 0)
            {
                a[x, y] = 2;
                a[x, y + 1] = 2;
            }
            else if (y == 4)
            {
                a[x, y] = 2;
                a[x, y - 1] = 2;
            }
            else if (x == 0)
            {
                a[x, y] = 2;
                a[x + 1, y] = 2;
            }
            else if (x == 4)
            {
                a[x, y] = 2;
                a[x - 1, y] = 2;
            }
            else
            {
                a[x, y] = 2;
                a[x + 1, y] = 2;
            }
        }
        public static void Make1Ship(int[,] a)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 4);
            int y = rnd.Next(0, 4);
            while (a[x, y] != 0)
            {
                x = rnd.Next(0, 4);
                y = rnd.Next(0, 4);
            }
            a[x, y] = 1;
        }
        public static int[,] MakeMap()
        {
            int[,] map = new int[5, 5];
            Make3Ship(map);
            Make2Ship(map);
            Make1Ship(map);
            while (!Check1(map))
            {
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        if (map[x, y] == 2 || map[x, y] == 1 || map[x, y] == 3)
                        {
                            map[x, y] = 0;
                        }
                    }
                }
                Make3Ship(map);
                Make2Ship(map);
                Make1Ship(map);
            }
            return map;
        }
    }
}
