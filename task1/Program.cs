using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void RecursiveSequence(int m, int n)
        {
            if (m > n) return;

            Console.WriteLine(m);

            RecursiveSequence(m + 1, n);

        }
        public static void Main(string[] args)
        {
            RecursiveSequence(1, 10);
            Console.ReadKey(); // Для того чтобы консоль не закрывалась раньше времени
        }
    }
}