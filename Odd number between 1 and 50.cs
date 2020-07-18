using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50;
            int[] odd = new int[n];

            int i = 0;

            Console.WriteLine("Odd Numbers:");
            for(i = 1; i<= n; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write(odd[i] + i + " ");
                }
            }
            Console.Read();
        }
    }
}
