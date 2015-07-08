using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = EnterC();
            var a = Entera();
            var A = C * (a * Math.PI / 180); //  Формула расчета катета А
            var b = Math.Pow(C, 2) - Math.Pow(A, 2); //  Формула расчета катета В
            var B = Math.Sqrt(b); //  Формула расчета катета В
            var p = A + B + C; //  Формула расчета периметра р
            var S = (A * B) / 2; //  Формула расчета площади S
            Console.WriteLine("Катет А равен = {0}", A);
            Console.WriteLine("Катет В равен = {0}", B);
            Console.WriteLine("Периметр треугольника равен = {0}", p);
            Console.WriteLine("Площадь треугольника ровна = {0}", S);
            Console.WriteLine("Нажмите кнопку для завершения программы.");
            Console.ReadKey();
        }

        /// <summary>
        /// Функция для возвращения вводимое пользователем значение гипотенузы
        /// </summary>
        /// <returns></returns>
        internal static float EnterC()
        {
            var result = 0f;
            while (result <= 0f)
            {  //  Цикл будет повторяется, пока не будет введено допустимое значение гипотенузы
                Console.Write("Введите значение гипотенузы: ");
                var value = Console.ReadLine(); //  значение пользователя
                Console.WriteLine();    //  Перевод строки ввода
                float.TryParse(value, out result);  //  Используем безопасное конвертирование строкового значения во float
                if (result <= 0)
                {
                    //  Информация об ошибоке в введенных данных
                    Console.WriteLine("ОШИБКА ВВОДА! Вводимое число должно быть числом не равное нулю и не меньшее нуля.");
                }
            }
            return result;
        }
        /// <summary>
        /// Функция для возвращения вводимое пользователем значение угла альфа
        /// </summary>
        /// <returns></returns>
        internal static float Entera()
        {
            var result = 0f;
            while (result <= 0f)
            {  //  Цикл будет повторяется, пока не будет введено допустимое значение угла альфа
                Console.Write("Введите значение угла альфа: ");
                var value = Console.ReadLine(); //  Пзначение пользователя
                Console.WriteLine();    //  Перевод строки ввода
                float.TryParse(value, out result);  //  Используем безопасное конвертирование строкового значения во float
                if (result <= 0)
                {
                    //  Информация об ошибоке в введенных данных
                    Console.WriteLine("ОШИБКА ВВОДА! Вводимое число должно быть числом не равное нулю и не меньшее нуля.");
                }
            }
            return result;
        }
    }
}