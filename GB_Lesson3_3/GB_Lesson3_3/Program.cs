using System;

namespace GB_Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любой произвольный текст");
            var str = Console.ReadLine();
            
            // разбиваем строку на массив символов
            char[] strReverse = str.ToCharArray();
            // Переворачиваем последовательность символов в массиве
            Array.Reverse(strReverse);

            Console.WriteLine(strReverse);
        }
    }
}
