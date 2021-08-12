using System;

namespace Task_4
{
    class Program
    {
        // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
     // является заданная последовательность элементами арифметической или геометрической прогрессии
     // 
     // Примечание
     //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
     //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
     
        static void Main(string[] args)
        {
            Console.WriteLine();
                Console.WriteLine("\nВВедите колличество элементов массива.");
                int count;
                if (int.TryParse(Console.ReadLine(), out count))
                {
                    int input;
                    int[] arr = new int[count];
                    Console.WriteLine("\nВВедите элементы массива.");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Введите число и нажмите Enter:");
                    if (int.TryParse(Console.ReadLine(), out input))
                    {

                        arr[i] = input;
                    }
                    else
                    {
                        Console.WriteLine("Введено не верное число.");
                        return;
                    }
                }
                    Console.WriteLine(CheckProgression(arr));
                }
                else
                {
                    Console.WriteLine("Неверные входные данные.");
                }
                Console.ReadKey();
            
        }
        /// <summary>
        /// Проверяет является ли массив
        /// арефметической или геометрической прогрессией
        /// </summary>
        /// <param name="arr">Массив для проверки</param>
        /// <returns>результат проверки в виде строки</returns>
        static string CheckProgression(int[] arr)
        {
            bool IsArithmeticProgression = true;
            bool IsGeometricProgression = true;
            int d = arr[1] - arr[0];
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] + d != arr[i + 1])
                { IsArithmeticProgression = false; }
            }
            if (CheckingCorrectnessInput(arr))
            {
                d = arr[1] / arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] * d != arr[i + 1])
                    { IsGeometricProgression = false; }

                }
            }
            else
            { return "в геометрической прогрессии не может быть нулей."; }

            if (IsArithmeticProgression)
            {
                return "Является арифметической прогрессией.";
            }
            else if (IsGeometricProgression)
            {
                return "Является геометрической прогрессией.";
            }
            else
            {
                return "Не является прогрессией.";
            }
        }
        /// <summary>
        /// Проверка есть ли в массиве число 0
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static bool CheckingCorrectnessInput(int[] arr)
        {
            bool confirmation = true;

            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i] != 0)
                {
                    { confirmation = true; }
                }
                else
                    confirmation= false;
            }
            return confirmation;
        }
    }
}
