using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        int[] colorCounts = new int[101];
        int pairs = 0;

        foreach (int sock in ar)
        {
            colorCounts[sock]++;
        }

        for (int i = 1; i <= 100; i++)
        {
            pairs += colorCounts[i] / 2;
        }

        return pairs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        if (outputPath == null)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = Result.sockMerchant(n, ar);
            Console.WriteLine(result);
            return;
        }

        TextWriter textWriter = new StreamWriter(outputPath, true);

        int nInput = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arInput = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int resultOutput = Result.sockMerchant(nInput, arInput);

        textWriter.WriteLine(resultOutput);

        textWriter.Flush();
        textWriter.Close();
    }
}
