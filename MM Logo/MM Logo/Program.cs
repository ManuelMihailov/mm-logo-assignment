using System;

namespace MM_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int mid;
            int top;
            string half;

            int n = int.Parse(Console.ReadLine());
            int bottom = 1;
            int bottomMid = n * 2 - 1;

            for (int i = 0; i <= n; i++)
            {
                if (i + 1 <= (n + 1) / 2)
                {
                    mid = n - (2 * i);
                    top = n + (i * 2);
                    half = $"{Print('-', n - i)}{Print('*', top)}{Print('-', mid <= 0 ? 0 : mid)}{Print('*', top)}{Print('-', n - i)}";
                    Console.WriteLine($"{half}{half}");
                }
                else
                {
                    half = $"{Print('-', n - i)}{Print('*', n)}{Print('-', bottom)}{Print('*', bottomMid)}{Print('-', bottom)}{Print('*', n)}{Print('-', n - i)}";
                    Console.WriteLine($"{half}{half}");
                    bottom += 2;
                    bottomMid -= 2;
                }
            }
        }

        static string Print(char symbol, int count)
        {
            return new string(symbol, count);
        }
    }
}
