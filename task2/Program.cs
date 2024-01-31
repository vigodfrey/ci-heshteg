public class Program
 {
     public static int RecursiveAckerman(int m, int n)
     {
         while (m != 0) 
         {
             if (n == 0)
             {
                 n = 1;
             }
             else
             {
                 n = RecursiveAckerman(m, n - 1);
             }
             m--;
         }
         return n + 1;
     }
     public static void Main(string[] args)
     {
         Console.Write(RecursiveAckerman(3, 5));
         Console.ReadKey(); // Для того чтобы консоль не закрывалась раньше времени
     }
 }