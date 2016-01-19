using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
         int n = Convert.ToInt32(ReadLine());
        int[] data = Array.ConvertAll(ReadLine().Split(' '), Int32.Parse);
        Array.Sort(data);
        List<Triplet> list = new List<Triplet>();
        for (int i = 0; i + 1 < n; i++)
        {
            int min = Math.Min(data[i], data[i + 1]);
            int max = Math.Max(data[i], data[i + 1]);
            int tmp = Math.Abs(max - min);
            list.Add(new Triplet() { A = min, B = max, Abs = tmp });
        }
        int test = list.Min(x => x.Abs);
        foreach (Triplet elem in list)
        {
            if (elem.Abs == test)
                Write($"{elem.A} {elem.B} ");
        }
    }
}
    class Triplet
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Abs { get; set; }
    }
