using System;

class Solution
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
 
        if (v1 <= v2)
        {
            return "NO";
        }

        if ((x2 - x1) % (v1 - v2) == 0)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }

    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int x1 = int.Parse(inputs[0]);
        int v1 = int.Parse(inputs[1]);
        int x2 = int.Parse(inputs[2]);
        int v2 = int.Parse(inputs[3]);

        Console.WriteLine(kangaroo(x1, v1, x2, v2));
    }
}
