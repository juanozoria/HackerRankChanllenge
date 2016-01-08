using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        double M = 1;
            double T = 1;
            double X = 1;
            M = double.Parse(Console.ReadLine());
            T = int.Parse(Console.ReadLine());
            X = int.Parse(Console.ReadLine());
            T = T * M / 100;
            X = X * M / 100;
            M = M + T + X;

            Console.WriteLine("The final price of the meal is $" + Math.Round(M) + ".");
            Console.ReadLine();
    }
}
