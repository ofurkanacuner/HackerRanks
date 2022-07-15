#region - Using

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion

namespace HackerRanks
{
    public class Simple_Array_Sum
    {
        public static int SimpleArraySum(List<int> ar)
        {
            int result = 0;
            foreach (int item in ar)
            {
                result += item;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Simple_Array_Sum.SimpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}