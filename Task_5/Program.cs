using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Введите первое число:");
            int firstNumber;
            if (int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.Write("Введите второе число:");
                int seconNumber;
                if (int.TryParse(Console.ReadLine(), out seconNumber))
                {
                    Console.WriteLine(A(firstNumber, seconNumber));
                    Console.Read();
                }
                else
                    Console.WriteLine("ВВедены не верные данные!");
            }
            else
                Console.WriteLine("ВВедены не верные данные!");
        }

        /// <summary>
        /// Проверяет правильность введеных данных
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static bool CheckingCorrectnessInput(int input)
        {
            if (input > 0)
            {
                return true;
            }
            else
                return false;

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
