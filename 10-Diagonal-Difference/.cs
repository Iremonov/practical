using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int n = arr.Count;
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += arr[i][i];
            secondaryDiagonalSum += arr[i][n - 1 - i];
        }

        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
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
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);
            Console.WriteLine(result);
            return;
        }

        TextWriter textWriter = new StreamWriter(outputPath, true);

        int nInput = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arrInput = new List<List<int>>();

        for (int i = 0; i < nInput; i++)
        {
            arrInput.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int resultOutput = Result.diagonalDifference(arrInput);

        textWriter.WriteLine(resultOutput);

        textWriter.Flush();
        textWriter.Close();
    }
}
