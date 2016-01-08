using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            var testCaseCount = Int32.Parse(Console.ReadLine());

            for (var i = 0; i < testCaseCount; i++)
            {
                var parametersTokens = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var a = Int32.Parse(parametersTokens[0]);

                var b = Int32.Parse(parametersTokens[1]);

                var n = Int32.Parse(parametersTokens[2]);

                var sum = a;

                var stringBuilder = new StringBuilder();

                for (var j = 0; j < n; j++) 
                {
                    sum += Convert.ToInt32(Math.Pow(2, j) * b);

                    stringBuilder.Append(sum);

                    stringBuilder.Append(' ');
                }

                Console.WriteLine(stringBuilder.ToString());
            }
        }
    }
