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
        }
            //задание 1.1
            /// <summary>
            /// Функция, принимающий число и матрицу, возвращающий матрицу умноженную на число
            /// </summary>
            static void Task1_1()
            {
                Console.WriteLine();
                Console.WriteLine("Введите колличество строк:");
                int lines;
                if (int.TryParse(Console.ReadLine(), out lines))
                {
                    Console.WriteLine("Введите колличество столбцов:");
                    int column;
                    if (int.TryParse(Console.ReadLine(), out column))
                    {
                        int[,] arr = new int[column, lines];
                        FillsInTheMatrix(arr);
                        PrintMatrix(arr);
                        Console.Write("ВВедите число:");
                        int operand;
                        if (int.TryParse(Console.ReadLine(), out operand))
                        {
                            int[,] result = MultiplicationByNumber(operand, arr);
                            PrintMatrix(result);
                        }
                        else
                            Console.WriteLine("Введено неверное число!");
                    }
                }
                else
                    Console.WriteLine("Введено неверное число!");
            }
            //Задание 1.2

            static void Task1_2() //метод, принимающий две матрицу, возвращающий их сумму
            {
                Console.WriteLine();
                Console.WriteLine("Введите колличество строк для первого массива");
                int lines;
                if (int.TryParse(Console.ReadLine(), out lines))
                {
                    Console.WriteLine("Введите колличество столбцов для первого массива");
                    int column;
                    if (int.TryParse(Console.ReadLine(), out column))
                    {
                        int[,] arr1 = new int[lines,column];
                        Console.WriteLine("Введите колличество строк для второго массива");
                        if (int.TryParse(Console.ReadLine(), out lines))
                        {
                            Console.WriteLine("Введите колличество столбцов для второго массива");
                            if (int.TryParse(Console.ReadLine(), out column))
                            {
                                int[,] arr2 = new int[lines, column];
                                if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1))
                                {
                                    FillsInTheMatrix(arr1);
                                    FillsInTheMatrix(arr2);
                                    PrintMatrix(arr1);
                                Console.WriteLine("\n" + "+" + "\n");
                                PrintMatrix(arr2);
                                    Console.WriteLine("\n" + "=" + "\n");
                                    int[,] result = MatriAddition(arr1, arr2);
                                    PrintMatrix(result);
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
                Console.WriteLine("Введите колличество строк для первого массива");
                int lines;
            if (int.TryParse(Console.ReadLine(), out lines) && lines > 0)
            {
                Console.WriteLine("Введите колличество столбцов для первого массива");
                int column;
                if (int.TryParse(Console.ReadLine(), out column) && column > 0)
                {
                    int[,] arr1 = new int[lines, column];
                    FillsInTheMatrix(arr1);
                    PrintMatrix(arr1);
                    Console.WriteLine("\n" + "*" + "\n");
                    Console.WriteLine("Введите колличество строк для второго массива");
                    if (int.TryParse(Console.ReadLine(), out lines) && lines > 0)
                    {
                        Console.WriteLine("Введите колличество столбцов для второго массива");
                        if (int.TryParse(Console.ReadLine(), out column) && column > 0)
                        {
                            int[,] arr2 = new int[lines, column];
                            FillsInTheMatrix(arr2);
                            PrintMatrix(arr2);
                            if (arr1.GetLength(1) == arr2.GetLength(0))
                            {
                                int[,] result = MatrixMultiplication(arr1, arr2);
                                Console.WriteLine("\n" + "=" + "\n");
                                PrintMatrix(result);
                            }
                            else
                            {
                                Console.WriteLine("Колличество строк первого массива не равен количеству столбцов второго массива!");
                            
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
                int lines;
            if (int.TryParse(Console.ReadLine(), out lines) && lines > 0)
            {
                    Console.WriteLine("Введите колличество столбцов для первого массива");
                    int column;
                if (int.TryParse(Console.ReadLine(), out column) && column > 0)
                {
                        int[,] arr1 = new int[lines, column];
                        Console.WriteLine("Введите колличество строк для второго массива");
                    if (int.TryParse(Console.ReadLine(), out lines) && lines > 0)
                    {
                            Console.WriteLine("Введите колличество столбцов для второго массива");
                        if (int.TryParse(Console.ReadLine(), out column) && column > 0)
                        {
                                int[,] arr2 = new int[lines, column];
                                if (arr1.Length == arr2.Length)
                                {
                                    FillsInTheMatrix(arr1);
                                    FillsInTheMatrix(arr2);
                                    PrintMatrix(arr1);
                                    Console.WriteLine("\n" + "-" + "\n");
                                    PrintMatrix(arr2);
                                    int[,] result = SubtractingMatrices(arr1, arr2);
                                    PrintMatrix(result);
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
            static int[,] MultiplicationByNumber(int operand, int[,] arr)//умножение матрицы на число
            {
            int lines = arr.GetLength(0);
            int column = arr.GetLength(1);
            int[,] result = new int[lines, column];
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        result[i, j] = arr[i, j] * operand;
                    }
                }
                return result;
            }
            /// <summary>
            /// Функция складывает две матрицы
            /// </summary>
            /// <param name="arr1"></param>
            /// <param name="arr2"></param>
            /// <returns></returns>
            static int[,] MatriAddition(int[,] arr1, int[,] arr2)//Сложение матриц
            {
            int lines = arr1.GetLength(0);
            int column = arr1.GetLength(1);
            int column2 = arr2.GetLength(1);

            int[,] resultMatrix = new int[lines, column2];
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < column; j++)
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
            int lines = arr1.GetLength(0);
            int column = arr2.GetLength(1);
            int column2 = arr2.GetLength(0);
            int[,] result = new int[lines, column];

                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        for (int k = 0; k < column2; k++)
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
            static int[,] SubtractingMatrices(int[,] arr1, int[,] arr2)//Вычитание матриц
            {
            int lines = arr1.GetLength(0);
            int column = arr1.GetLength(1); 
            int[,] result = new int[lines, column];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    result[i, j] = arr2[i, j] - arr1[i, j];
                    }
                }
                return result;
            }

        /// <summary>
        /// Печатает Матрицы
        /// </summary>
            static void PrintMatrix(int[,] arr)
        {
            int lines = arr.GetLength(0);
            int column = arr.GetLength(1);
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Метод заполняющий матрицу
        /// </summary>
        /// <param name="arr"></param>
        static void FillsInTheMatrix(int [,] arr)
        {
            Random rand = new Random();
            int lines = arr.GetLength(0);
            int column = arr.GetLength(1);
            for (int i = 0; i <lines; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr[i, j] = rand.Next(1, 11);
                }
            }
        }

    }
}
