using System;

class Program
{
    static void Main()
    {
        int n = 6;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}
