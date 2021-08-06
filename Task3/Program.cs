using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
           
                Console.WriteLine();
                Console.WriteLine("ВВедите строку с задвоенными символами.");
                Console.WriteLine("В Результате работы метода,получится новый текст в котором удалены все кратные рядом стоящие символы, оставив по одному .");
                string input = Console.ReadLine();
                Console.WriteLine(Conversions(input));
                Console.Read();
            
        }
        /// <summary>
        /// Удаляет задвоенные символы в строке
        /// </summary>
        /// <param name="input"></param>
        /// <returns>возвращает строку без задвоенных букв</returns>
        static string Conversions(string input)//Удаляет задвоенные символы в строке.
        {
            input = input.ToLower();
            string word = input[0].ToString();
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] != input[i])
                {
                    word += input[i];
                }
            }
            return word;
        }
    }
}
