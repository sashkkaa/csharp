using System;

namespace GB_Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для проверки");
            var num = Console.ReadLine();

            // Проверяем что ввел пользователь, числовое ли значение
            bool flagInt = Int32.TryParse(num, out int i); ;

            while (flagInt == false)
            {
                Console.WriteLine("Значение должно быть числовым!");
                num = Console.ReadLine();
                flagInt = Int32.TryParse(num, out i);
            };

            bool flagEven = (Int32.Parse(num) % 2 == 0);

            if (flagEven == true)
            {
                Console.WriteLine("Число четное");
            } else 
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}
