using System;

class Solution
{
    public static int pageCount(int n, int p)
    {
        int fromFront = p / 2;
        int fromBack = (n / 2) - (p / 2);
        
        return Math.Min(fromFront, fromBack);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = pageCount(n, p);

        Console.WriteLine(result);
    }
}
