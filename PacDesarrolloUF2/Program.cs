using System;

namespace PacDesarrolloUF2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[10, 10];

            int n = 0;
            
            for (int y = 1; y <= 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (EsPrimo(n) == true)
                    {
                        Console.Write($" {n}");
                    }
                    else
                    {
                        Console.Write(" X ");
                    }                                       
                    n++;                    
                }
                Console.WriteLine(" ");                
            }
                Console.ReadKey();
        }

        public static bool EsPrimo(int n)
        {
            if (n == 1)
                return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
