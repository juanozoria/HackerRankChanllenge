using System;
using System.Collections.Generic;
using System.IO;
class Solution {
//Recursion
     public static int FindGcd(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else if (a == 1 || b == 1)
            {
                return 1;
            }
            else
            {
                return FindGcd(a > b ? a - b : a, b > a ? b - a : b);
            }
        }
     static void Main(string[] args)
        {
         //Read line, and split it by whitespace into an array of strings
            string[] tokens = Console.ReadLine().Split();
            //Parse element 0
            int a = int.Parse(tokens[0]);
            //Parse element 1
            int b = int.Parse(tokens[1]);
                Console.WriteLine(FindGcd(a, b));

     }
}
