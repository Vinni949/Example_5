using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            
            //
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
                switch (Console.ReadKey().Key)
                {
                   
                   
                   
                    default:
                        Console.WriteLine("Нажата неверна клавиша, введите снова!");
                        break;
                }
            }
        }
        
        
       


        

        //Задание 5
        
    }
}

