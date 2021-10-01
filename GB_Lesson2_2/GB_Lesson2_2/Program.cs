using System;

namespace GB_Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем значение у пользователя
            Console.WriteLine("Введите порядковый номер месяца");
            var monthNum = Console.ReadLine(); ;

           // Проверяем что ввел пользователь, числовое ли значение
            bool flagInt = Int32.TryParse(monthNum, out int i); ;

            while (flagInt == false)
            {
                Console.WriteLine("Значение должно быть числовым!");
                monthNum = Console.ReadLine();
                flagInt = Int32.TryParse(monthNum, out i);
            };

            // Проверяем существует ли месяц с таким порядковым номером
            bool flagExist = (0 < Convert.ToInt32(monthNum) && Convert.ToInt32(monthNum) <= 12);

            while (flagExist == false)
            {
                Console.WriteLine("Значение должно находиться в промежутке между 1 и 12");
                monthNum = Console.ReadLine();
                flagExist = (0 < Convert.ToInt32(monthNum) && Convert.ToInt32(monthNum) <= 12);
            };
            
            // Выводим название месяца
            DateTime month = new DateTime(2021, Convert.ToInt32(monthNum), 1);
            Console.WriteLine($"Название заданного месяца: {month.ToString("MMMM")}");
        }
    }
}
