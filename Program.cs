using System;

namespace horse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] alph = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            int a = Array.IndexOf(alph, input[0]) + 1;
            int b = (int)char.GetNumericValue(input[1]);
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if ((Math.Abs(i - a) == 1 && Math.Abs(j - b) == 2) || (Math.Abs(i - a) == 2 && Math.Abs(j - b) == 1))
                    {
                        Console.WriteLine(Convert.ToString(alph[i - 1]) + Convert.ToString(j));
                    }
                }
            }
        }
    }
}
