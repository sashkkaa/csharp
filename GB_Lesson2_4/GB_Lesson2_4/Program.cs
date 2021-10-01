using System;

namespace GB_Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string head = "Добро пожаловать !";
            DateTime today = DateTime.Today;
            string main = "Продажа:";
            int num = 1;
            string product = "Упаковка стандартная с бантом";
            string total = "Итог:";
            decimal sum = 1003.92M;

            Console.WriteLine(head);
            Console.WriteLine(today);
            Console.WriteLine(main);
            Console.WriteLine(num + ". " + product);
            Console.WriteLine(total + sum);
        }
    }
}
