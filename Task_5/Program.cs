using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Введите первое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            int seconNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A(firstNumber, seconNumber));
            Console.Read();
        }

        /// <summary>
        /// Рекурсия функции Аккермана
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns>Возвращает рекурсию</returns>
        static int A(int n, int m)// вычисляет функцию Аккермана и возвращает результат в виде числа.
        {
            if (n == 0) return m + 1;
            if (n != 0 && m == 0) return A(n - 1, 1);
            if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
            return A(n, m);
        }


    }
}
