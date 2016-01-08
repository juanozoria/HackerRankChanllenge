using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int T = Convert.ToInt16(Console.ReadLine());
            for (Int16 i = 1; i <= T; ++i)
            {
                for (int j = 1; j <= T; ++j)
                {
                    if (j <= T - i)
                        Console.Write(" ");
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
    }
}
