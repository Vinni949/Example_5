using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        // Задание 2.
        // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
        // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
        // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
        // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
        // 1. Ответ: А
        // 2. ГГГГ, ДДДД
        static void Main(string[] args)
        {
            
                Console.WriteLine();
                Console.WriteLine("Введите текст:");
                string txt = Console.ReadLine();
                string minWord = MinWord(txt);
                Console.WriteLine("Самое короткое слово : " + minWord);
                string maxWord = MaxWord(txt);
                Console.WriteLine("Самое длинное слово:" + maxWord);
                Console.Read();
            

        }

        /// <summary>
        /// фунция находит минимальное слово в строке
        /// </summary>
        /// <param name="txt"></param>
        /// <returns>строку с минимальными словами</returns>
        static string MinWord(string txt)//слово с минимальной длиной.
        {
            List<string> listWord = new List<string>();
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
                    listWord.Add(str);
                    str = "";
                }
            }
            int buf = 10;
            for (int i = 0; i < listWord.Count; i++)
            {
                if (buf > listWord[i].Count() && listWord[i].Count() != 0)
                {
                    buf = listWord[i].Count();
                    minWord = listWord[i];
                }
                else if (buf == listWord[i].Count())
                {
                    minWord += ", ";
                    minWord += listWord[i];
                }
            }
            return minWord;
        }

        /// <summary>
        /// фунция находит максимальное слово в строке
        /// </summary>
        /// <param name="txt"></param>
        /// <returns>строку с максимальной длинной слов</returns>
        static string MaxWord(string txt)//слов с максимальной длиной.
        {
            List<string> listWord = new List<string>();
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
                    listWord.Add(str);
                    str = "";
                }
            }
            int buf = 0;
            for (int i = 0; i < listWord.Count; i++)
            {
                if (buf < listWord[i].Count())
                {
                    buf = listWord[i].Count();
                    maxWord = listWord[i];
                }
                else if (buf == listWord[i].Count())
                {
                    maxWord += ", ";
                    maxWord += listWord[i];
                }
            }
            return maxWord;
        }
    }
}
