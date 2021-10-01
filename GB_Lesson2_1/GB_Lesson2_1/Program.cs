using System;

namespace GB_Lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxTemp = "";

            // Получаем максимальную суточную температура с проверкой на вводимое значение пользователем
            while (Int32.TryParse(maxTemp, out int i) == false)
            {
                Console.WriteLine("Введите максимальную температуру за сутки");
                maxTemp = Console.ReadLine();

                // Если пользователь ввел не числовое значение, выдаем предупреждение
                if (Int32.TryParse(maxTemp, out i) == false)
                    Console.WriteLine("Значение должно быть числовым!");
            }

            var minTemp = "";

            // Получаем минимальную суточную температура с проверкой на вводимое значение пользователем
            while (Int32.TryParse(minTemp, out int i) == false)
            {
                Console.WriteLine("Введите минимальную температуру за сутки");
                minTemp = Console.ReadLine();

                // Если пользователь ввел не числовое значение, выдаем предупреждение
                if (Int32.TryParse(minTemp, out i) == false)
                    Console.WriteLine("Значение должно быть числовым!");
            }
          
            //Вычисляем среднюю температуру, предварительно преобразовав строку в число
            var avgTemp = (Convert.ToInt32(maxTemp) + Convert.ToInt32(minTemp)) / 2;

            Console.WriteLine($"Среднесуточная температура: {avgTemp}");
        }
    }
}
