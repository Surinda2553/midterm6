using System;

namespace midterm6
{
    class Program
    {
        static void Main(string[] args)
        {
            Char symbol = Console.ReadLine()[0];
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            int step = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= step; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    for (int k = 0; k < width * i; k++)
                    {
                        Console.Write(symbol);
                    }
                    Console.Write("\n");
                }
            };

        }
    }
}
