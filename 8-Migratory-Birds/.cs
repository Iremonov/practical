using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        int[] counts = new int[6];

        foreach (int bird in arr)
        {
            counts[bird]++;
        }

        int maxCount = 0;
        int mostFrequentBirdId = 1;

        for (int i = 1; i <= 5; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                mostFrequentBirdId = i;
            }
        }

        return mostFrequentBirdId;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        if (outputPath == null)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = Result. migratoryBirds(arr);
            Console.WriteLine(result);
            return;
        }

        TextWriter textWriter = new StreamWriter(outputPath, true);

        int arrCountInput = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arrInput = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int resultOutput = Result.migratoryBirds(arrInput);

        textWriter.WriteLine(resultOutput);

        textWriter.Flush();
        textWriter.Close();
    }
}
