#region - Using

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion

namespace HackerRanks
{
    public class Compare_the_Triplets
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int aliceCounter = 0, bobCounter = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    aliceCounter++;
                else
                if (a[i] < b[i])
                    bobCounter++;
            }

            return new List<int>() { { aliceCounter }, { bobCounter } };
        }


        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Compare_the_Triplets.CompareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }

    }
}