using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution*/
        int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string phone = Console.ReadLine();
                phoneBook.Add(name, phone);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                    break;
                string phone;
                if (phoneBook.TryGetValue(input, out phone) == true)
                    Console.WriteLine(input + "=" + phone);
                else
                    Console.WriteLine("Not found");
            }
    }
}
