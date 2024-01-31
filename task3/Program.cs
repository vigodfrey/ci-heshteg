using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void RecursiveArrayDisplay(int[] arr, int i)
        {
            if (i < 0) return;

            Console.WriteLine(arr[i]);           

            RecursiveArrayDisplay(arr, i - 1);
           
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6 };

            RecursiveArrayDisplay(arr, arr.Length - 1);
            Console.ReadKey(); // Для того чтобы консоль не закрывалась раньше времени
        }
    }
}