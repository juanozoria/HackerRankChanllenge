using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
            int[,] matriz = new int[6, 6];
            for (int i = 0; i < 6; i++)
            {
                string linea = Console.ReadLine();

                int j = 0;
                foreach (var num in linea.Split(' '))
                {
                    matriz[j, i] = int.Parse(num);
                    j++;
                }
            }

            List<int> hourglasses = new List<int>();

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    int hg = 0;
                    for (int c = 0; c < j + 3; c++)
                    {

                        if (c == j)
                            hg += matriz[i, c] + matriz[i + 1, c] + matriz[i + 2, c];
                        if (c == j + 1)
                            hg += matriz[i + 1, c];
                        if (c == j + 2)
                            hg += matriz[i, c] + matriz[i + 1, c] + matriz[i + 2, c];

                    }
                    hourglasses.Add(hg);
                }
            }
            Console.Write(hourglasses.Max());

    }
}
