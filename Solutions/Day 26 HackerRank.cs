using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int[] arrActual = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] arrExpected = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            if (arrActual[2] > arrExpected[2])
            {
                Console.WriteLine(10000);
            }
            else if (arrActual[2] == arrExpected[2])
            {
                if (arrActual[1] > arrExpected[1])
                {
                    Console.WriteLine(500 * Math.Abs(arrActual[1] - arrExpected[1]));
                }
                else if (arrActual[1] == arrExpected[1])
                {
                    if (arrActual[0] <= arrExpected[0])
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(15 * Math.Abs(arrActual[0] - arrExpected[0]));
                    }
                }
                else if (arrActual[1] < arrExpected[1])
                {
                    Console.WriteLine(0);
                }
            }
            else if (arrActual[2] < arrExpected[2])
            {
                Console.WriteLine(0);
            }

            Console.ReadKey();
    }
}
