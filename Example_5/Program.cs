using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
            // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
            //
            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД
            //
            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
            // 
            // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии
            // 
            // Примечание
            //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
            //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
            //
            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 
            // Весь код должен быть откоммментирован

            bool choice = true;
            while (choice)
            {
                Console.WriteLine("Введите номер: \n1-задание №1, 2-задание №2, 3-задание №3, 4-задание №4, 5-задание №5.");
                Console.WriteLine("0-exit");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 0:
                        choice = false;
                        break;
                }
            }

            static void Task1()
            {
                bool choice = true;
                while (choice)
                {
                    Console.WriteLine("Введите номер: \n1-задание №1.1, 2-задание №1.2, 3-задание №1.3.");
                    Console.WriteLine("0-exit");
                    int a;
                    string input = Console.ReadLine();
                    int.TryParse(input, out a);
                    switch (a)
                    {
                        case 1:
                            Task1_1();
                            break;

                        case 2:
                            Task1_2();
                            break;
                        case 3:
                            Task1_3();
                            break;

                        case 0:
                            choice = false;
                            break;
                    }
                }
            }
            //задание 1.1
            static void Task1_1()
            {
                int a = 0;
                Console.WriteLine("Введите колличество столбцов:");
                int column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите колличество строк:");
                int lines= Convert.ToInt32(Console.ReadLine());
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
                Number(operand, arr);
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
            //Задание 1.2
            static void Task1_2()
            {
                Console.WriteLine("Введите колличество столбцов для первого массива");
                int column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите колличество строк для первого массива");
                int lines = Convert.ToInt32(Console.ReadLine());
                int[,] arr1 = new int[column, lines];
                Console.WriteLine("Введите колличество столбцов для второго массива");
                column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите колличество строк для второго массива");
                lines = Convert.ToInt32(Console.ReadLine());
                int[,] arr2 = new int[column, lines];

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

                Amount(arr1, arr2);
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
            //задание 1.3
            static void Task1_3()
            {
                Console.WriteLine("Введите колличество столбцов для первого массива");
                int column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите колличество строк для первого массива");
                int lines = Convert.ToInt32(Console.ReadLine());
                int[,] arr1 = new int[column, lines];
                Console.WriteLine("Введите колличество столбцов для второго массива");
                column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите колличество строк для второго массива");
                lines = Convert.ToInt32(Console.ReadLine());
                int[,] arr2 = new int[column, lines];

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
                Console.WriteLine("\n" + "*" + "\n");
                int[,] result = Composition(arr1, arr2);
                Console.WriteLine("\n" + "=" + "\n");
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
            //Задание 2
            static void Task2()
            {
                Console.WriteLine("Введите текст:");
                string txt = Console.ReadLine();
                string minWord = MinWord(txt);
                Console.WriteLine("Самое короткое слово : " + minWord);
                string maxWord = MaxWord(txt);
                Console.WriteLine("Самое длинное слово:" + maxWord);
                Console.Read();
            }
            //задание 3
            static void Task3()
            {
                string input = Console.ReadLine();
                Console.WriteLine(Conversions(input));
                Console.Read();
            }
            //задание 4
            static void Task4()
            {
                string input = Console.ReadLine();
                Console.WriteLine(ArithmeticProgressionConversions(input));
                Console.WriteLine(GeometricProgressionConversions(input));
                Console.Read();
            }
            //Задание 5
            static void Task5()
            {
                Console.Write("Введите первое число:");
                int number1 = Convert.ToInt32(Console.Read());
                Console.Write("Введите второе число:");
                int number2 = Convert.ToInt32(Console.Read());
                Console.WriteLine(A(number1, number2));
                Console.WriteLine(A(number1, number2));
                Console.Read();
            }

            static void Number(int operand, int[,] arr)
            {

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] *= operand;
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            static void Amount(int[,] arr1, int[,] arr2)
            {
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        arr2[i, j] += arr1[i, j];
                    }
                }
            }

            static int[,] Composition(int[,] arr1, int[,] arr2)
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

            static string MinWord(string txt)
            {
                List<string> list = new List<string>();
                string minWord = "";
                string str = "";
                for (int i = 0; i < txt.Length; i++)
                {

                    if (txt[i] != ' ')
                    {
                        str += txt[i];
                    }
                    else
                    {
                        list.Add(str);
                        str = "";
                    }
                }
                int buf = 10;
                for (int i = 0; i < list.Count; i++)
                {
                    if (buf > list[i].Count() && list[i].Count() != 0)
                    {
                        buf = list[i].Count();
                        minWord = list[i];
                    }
                }
                return minWord;
            }

            static string MaxWord(string txt)
            {
                List<string> list = new List<string>();
                string maxWord = "";
                string str = "";
                for (int i = 0; i < txt.Length; i++)
                {

                    if (txt[i] != ' ')
                    {
                        str += txt[i];
                    }
                    else
                    {
                        list.Add(str);
                        str = "";
                    }
                }
                int buf = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (buf < list[i].Count())
                    {
                        buf = list[i].Count();
                        maxWord = list[i];
                    }
                    else if (buf == list[i].Count())
                    {
                        maxWord += ", ";
                        maxWord += list[i];
                    }
                }
                return maxWord;
            }

            static string Conversions(string input)
            {
                string word = "";
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i - 1] != input[i])
                    {
                        word += input[i];
                    }
                }
                return word;
            }

            static bool ArithmeticProgressionConversions(string input)
            {
                string word = "";
                List<string> list = new List<string>();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ' && input[i] != ',')
                    {
                        word += input[i];
                    }
                    else
                    {
                        list.Add(word);
                        word = "";
                    }
                }

                if (list.Count >= 3)
                {
                    double[] arr = new double[list.Count];
                    for (int i = 0; i < list.Count; i++)
                    {
                        double a;
                        double.TryParse(list[i], out a);
                        arr[i] = a;
                    }
                    double d = arr[1] - arr[0];
                    for (int i = 1; i < arr.Length - 1; i++)
                    {
                        if (arr[i] + d != arr[i + 1])
                            return false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }

            }

            static bool GeometricProgressionConversions(string input)
            {
                string word = "";
                List<string> list = new List<string>();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ' && input[i] != ',')
                    {
                        word += input[i];
                    }
                    else
                    {
                        list.Add(word);
                        word = "";
                    }
                }

                if (list.Count >= 3)
                {
                    double[] arr = new double[list.Count];
                    for (int i = 0; i < list.Count; i++)
                    {
                        double a;
                        double.TryParse(list[i], out a);
                        arr[i] = a;
                    }
                    double d = arr[1] / arr[0];
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        if (arr[i] * d != arr[i + 1])
                            return false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }

            }

            static int A(int n, int m)
            {
                if (n == 0) return m + 1;
                if (m == 0) return A(n - 1, m);
                return A(n - 1, A(n, m - 1));
            }
        }
    }
}