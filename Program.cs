using System;
namespace horse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int a = (int)input[0];
            int b = (int)char.GetNumericValue(input[1]);
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if ((Math.Abs(i+96 - a) == 1 && Math.Abs(j - b) == 2) || (Math.Abs(i+96 - a) == 2 && Math.Abs(j - b) == 1))
                    {
                        Console.WriteLine(Convert.ToChar(96+i) + Convert.ToString(j));
                    }
                }
            }
        }
    }
}
