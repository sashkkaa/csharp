using System;

namespace GB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");

            // Имя пользователя задается путем ввода в консоли
            var userName = Console.ReadLine();

            // Текущая дата в формате ДД/ММ/ГГГГ
            var today = DateTime.Today.ToString("D");

            // Вывод сообщения пользователю
            Console.WriteLine($"Привет {userName}, сегодня {today}!");
        }
    }
}
