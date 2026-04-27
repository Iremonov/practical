using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    // This is the "Front Door" the compiler is looking for
    static void Main(string[] args) {
        // Read house range (s and t)
        string[] st = Console.ReadLine().Split(' ');
        int s = int.Parse(st[0]);
        int t = int.Parse(st[1]);

        string[] ab = Console.ReadLine().Split(' ');
        int a = int.Parse(ab[0]);
        int b = int.Parse(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        List<int> apples = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> oranges = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges) {
        int appleCount = 0;
        int orangeCount = 0;

        foreach (int d in apples) {
            if (a + d >= s && a + d <= t) appleCount++;
        }

        foreach (int d in oranges) {
            if (b + d >= s && b + d <= t) orangeCount++;
        }

        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
    }
}
