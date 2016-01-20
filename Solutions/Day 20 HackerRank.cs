using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] input = Console.ReadLine().Split(new char[] { ' ', '.', '?', '@', '\'', ',', '[', ']', '\\', '+', '/', '!', '_' },
            StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(input.Count());

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
    }
}
