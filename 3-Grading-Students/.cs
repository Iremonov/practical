using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            int grade = int.Parse(Console.ReadLine()!);
            if (grade >= 38)
            {
                int nextMultipleOf5 = ((grade / 5) + 1) * 5;

                if (nextMultipleOf5 - grade < 3)
                {
                    grade = nextMultipleOf5;
                }
            }

            Console.WriteLine(grade);
        }
    }
}
