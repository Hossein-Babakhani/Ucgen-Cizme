using System;

namespace Üçgen_Çizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin boyutunu girin:");
            int boyut = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= boyut; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
