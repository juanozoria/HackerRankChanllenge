using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
         int n = Convert.ToInt32(ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
            numbers[i] = Convert.ToInt32(ReadLine());
        foreach (int num in numbers)
        {
            if (IsPrime(num) == true)
                WriteLine("Prime");
            else
                WriteLine("Not prime");
        }
        ReadKey();
    }

    public static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        double tmp = Math.Ceiling(Math.Sqrt(n));
        for (int i = 2; i < tmp; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

}
