using System;

namespace Task_1
{
    class Program
    {
        // Домашнее задание
        // Требуется написать несколько методов
        //
        // Задание 1.
        // Воспользовавшись решением задания 3 четвертого модуля
        // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
        // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
        // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
        static void Main(string[] args)
        {
            bool choice = true;
            while (choice)
            {
                Console.WriteLine();
                Console.WriteLine("Введите номер: \n1-задание 'Умножение матрицы на число', 2-задание 'Сложение матриц', \n3-задание 'умножение матриц',4-задание 'Вычитание матриц'.");
                Console.WriteLine("0-exit");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Task1_1();
                        break;
                    case ConsoleKey.D2:
                        Task1_2();
                        break;
                    case ConsoleKey.D3:
                        Task1_3();
                        break;
                    case ConsoleKey.D4:
                        Task1_4();
                        break;
                    case ConsoleKey.D0:
                        choice = false;
                        break;
                    default:
                        Console.WriteLine("Нажата неверна клавиша, введите снова!");
                        break;
                }
            }

            //задание 1.1
            /// <summary>
            /// Функция, принимающий число и матрицу, возвращающий матрицу умноженную на число
            /// </summary>
            static void Task1_1()
            {
                Console.WriteLine();
                int a = 0;
                Console.WriteLine("Введите колличество столбцов:");
                int column = Convert.ToInt32(Console.ReadLine());
                if (CheckingCorrectnessInput(column))
                {
                    Console.WriteLine("Введите колличество строк:");
                    int lines = Convert.ToInt32(Console.ReadLine());
                    if (CheckingCorrectnessInput(lines))
                    {
                        int[,] arr = new int[column, lines];
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                a++;
                                arr[i, j] = a;
                            }
                        }
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                Console.Write(arr[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.Write("ВВедите число:");
                        int operand = Convert.ToInt32(Console.ReadLine());
                        MultiplicationByNumber(operand, arr);
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                Console.Write(arr[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.Read();
                    }
                }
                else
                    Console.WriteLine("Введено неверное число!");
            }
            //Задание 1.2

            static void Task1_2() //метод, принимающий две матрицу, возвращающий их сумму
            {
                Console.WriteLine();
                Console.WriteLine("Введите колличество столбцов для первого массива");
                int column = Convert.ToInt32(Console.ReadLine());
                if (CheckingCorrectnessInput(column))
                {
                    Console.WriteLine("Введите колличество строк для первого массива");
                    int lines = Convert.ToInt32(Console.ReadLine());
                    if (CheckingCorrectnessInput(lines))
                    {
                        int[,] arr1 = new int[column, lines];
                        Console.WriteLine("Введите колличество столбцов для второго массива");
                        column = Convert.ToInt32(Console.ReadLine());
                        if (CheckingCorrectnessInput(column))
                        {
                            Console.WriteLine("Введите колличество строк для второго массива");
                            lines = Convert.ToInt32(Console.ReadLine());
                            if (CheckingCorrectnessInput(lines))
                            {
                                int[,] arr2 = new int[column, lines];
                                if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1))
                                {
                                    int a = 0;
                                    for (int i = 0; i < arr1.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < arr1.GetLength(1); j++)
                                        {
                                            a++;
                                            arr1[i, j] = a;
                                            arr2[i, j] = a;
                                            Console.Write(arr1[i, j] + " ");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine("\n" + "+" + "\n");

                                    int[,] result = MatriAddition(arr1, arr2);
                                    for (int i = 0; i < result.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < result.GetLength(1); j++)
                                        {
                                            Console.Write(result[i, j] + " ");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.Read();
                                }
                                else { Console.WriteLine("Матрицы разных размеров"); }
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("Введено неверное число!");
            }

            //задание 1.3
            static void Task1_3()//Умножение матриц
            {
                Console.WriteLine();
                Console.WriteLine("Введите колличество столбцов для первого массива");
                int column = Convert.ToInt32(Console.ReadLine());
                if (CheckingCorrectnessInput(column))
                {
                    Console.WriteLine("Введите колличество строк для первого массива");
                    int lines = Convert.ToInt32(Console.ReadLine());
                    if (CheckingCorrectnessInput(lines))
                    {
                        int[,] arr1 = new int[column, lines];
                        int a = 0;
                        for (int i = 0; i < column; i++)
                        {
                            for (int j = 0; j < lines; j++)
                            {
                                a++;
                                arr1[i, j] = a;
                                Console.Write(arr1[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\n" + "*" + "\n");
                        Console.WriteLine("Введите колличество столбцов для второго массива");
                        column = Convert.ToInt32(Console.ReadLine());
                        if (CheckingCorrectnessInput(column))
                        {
                            Console.WriteLine("Введите колличество строк для второго массива");
                            lines = Convert.ToInt32(Console.ReadLine());
                            if (CheckingCorrectnessInput(lines))
                            {
                                int[,] arr2 = new int[column, lines];
                                a = 0;
                                for (int i = 0; i < column; i++)
                                {
                                    for (int j = 0; j < lines; j++)
                                    {
                                        a++;
                                        arr2[i, j] = a;
                                        Console.Write(arr2[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                if (arr1.GetLength(0) == arr2.GetLength(1) && arr1.GetLength(1) == arr2.GetLength(0))
                                {
                                    int[,] result = MatrixMultiplication(arr1, arr2);
                                    Console.WriteLine("\n" + "=" + "\n");
                                    for (int i = 0; i < result.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < result.GetLength(1); j++)
                                        {
                                            Console.Write(result[i, j] + " ");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.Read();
                                }
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("Введено неверное число!");
            }
            //задание 1.4
            static void Task1_4() //Вычитание матриц
            {
                Console.WriteLine();
                Console.WriteLine("Введите колличество строк для первого массива");
                int lines = Convert.ToInt32(Console.ReadLine());
                if (CheckingCorrectnessInput(lines))
                {
                    Console.WriteLine("Введите колличество столбцов для первого массива");
                    int column = Convert.ToInt32(Console.ReadLine());
                    if (CheckingCorrectnessInput(column))
                    {
                        int[,] arr1 = new int[column, lines];
                        Console.WriteLine("Введите колличество столбцов для второго массива");
                        column = Convert.ToInt32(Console.ReadLine());
                        if (CheckingCorrectnessInput(column))
                        {
                            Console.WriteLine("Введите колличество строк для второго массива");
                            lines = Convert.ToInt32(Console.ReadLine());
                            if (CheckingCorrectnessInput(lines))
                            {
                                int[,] arr2 = new int[column, lines];
                                if (arr1.Length == arr2.Length)
                                {
                                    int a = 0;
                                    for (int i = 0; i < arr1.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < arr1.GetLength(1); j++)
                                        {
                                            a++;
                                            arr1[i, j] = a;
                                            arr2[i, j] = a;
                                            Console.Write(arr1[i, j] + " ");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine("\n" + "-" + "\n");

                                    SubtractingMatrices(arr1, arr2);
                                    for (int i = 0; i < arr1.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < arr1.GetLength(1); j++)
                                        {
                                            Console.Write(arr1[i, j] + " ");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.Read();
                                }
                                else { Console.WriteLine("Матрицы разных размеров"); }
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("Введено неверное число!");
            }
            /// <summary>
            /// Функция умножает матрицу на число 
            /// </summary>
            /// <param name="operand"></param>
            /// <param name="arr"></param>
            static void MultiplicationByNumber(int operand, int[,] arr)//умножение матрицы на число
            {

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] *= operand;
                    }
                }
            }
            /// <summary>
            /// Функция складывает две матрицы
            /// </summary>
            /// <param name="arr1"></param>
            /// <param name="arr2"></param>
            /// <returns></returns>
            static int[,] MatriAddition(int[,] arr1, int[,] arr2)//Сложение матриц
            {
                int[,] resultMatrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        resultMatrix[i, j] = arr2[i, j] + arr1[i, j];
                    }
                }
                return resultMatrix;

            }
            /// <summary>
            /// Функция умножения матриц
            /// </summary>
            /// <param name="arr1"></param>
            /// <param name="arr2"></param>
            /// <returns></returns>
            static int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)//Умножение матриц
            {
                int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];

                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2.GetLength(1); j++)
                    {
                        for (int k = 0; k < arr2.GetLength(0); k++)
                        {
                            result[i, j] += arr1[i, k] * arr2[k, j];
                        }
                    }
                }
                return result;

            }
            /// <summary>
            /// Функция вычитает одну матрицу из другой
            /// </summary>
            /// <param name="arr1"></param>
            /// <param name="arr2"></param>
            static void SubtractingMatrices(int[,] arr1, int[,] arr2)//Вычитание матриц
            {
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        arr2[i, j] -= arr1[i, j];
                    }
                }
            }

            static bool CheckingCorrectnessInput(int input)
            {
                if (input > 0)
                {
                    return true;
                }
                else
                    return false;

            }
        }
    }
}
