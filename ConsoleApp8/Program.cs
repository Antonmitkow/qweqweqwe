using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine(), a = "";
            char B = Convert.ToChar(Console.ReadLine());
            for (int i=0; i <A.Length;i++)
            {
                if (A[i] == B)
                {
                    a = A.Insert(i + 1,B.ToString());
                }
            }
            Console.WriteLine("Результат: " + a);
            Console.ReadKey();
        }
    }
}
