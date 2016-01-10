using System;
using System.Collections.Generic;
using System.IO;
class Solution {
//Convert Decimal to Binary
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
            int decimalNumber =0;
            int remainder;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                decimalNumber  = int.Parse(Console.ReadLine());
               
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine(result);
                result = string.Empty;
            }          
    }
}
