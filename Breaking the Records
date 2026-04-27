using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static List<int> breakingRecords(List<int> scores)
    {
        int highest = scores[0];
        int lowest = scores[0];
        
        int highBreaks = 0;
        int lowBreaks = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > highest)
            {
                highest = scores[i];
                highBreaks++;
            }
            else if (scores[i] < lowest)
            {
                lowest = scores[i];
                lowBreaks++;
            }
        }

        return new List<int> { highBreaks, lowBreaks };
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        List<int> scores = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        List<int> result = breakingRecords(scores);
        
        Console.WriteLine(string.Join(" ", result));
    }
}
