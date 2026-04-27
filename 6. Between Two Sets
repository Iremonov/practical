using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int GetGCD(int a, int b) => b == 0 ? a : GetGCD(b, a % b);

    static int GetLCM(int a, int b) => (a * b) / GetGCD(a, b);

    public static int getTotalX(List<int> a, List<int> b)
    {
        int lcmA = a.Aggregate((current, next) => GetLCM(current, next));

        int gcdB = b.Aggregate((current, next) => GetGCD(current, next));

        int count = 0;
        for (int i = lcmA; i <= gcdB; i += lcmA)
        {
            if (gcdB % i == 0)
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        List<int> a = new List<int> { 3, 4 };
        List<int> b = new List<int> { 24, 48 };
        Console.WriteLine(getTotalX(a, b)); 
    }
}
