using System;

namespace GB_Lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем двумерный массив
            int[,] arr = new int[5, 5];

            // Объект для заполнения массива рандомными значениями
            Random rnd = new Random();


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // Заполняем массив 
                    if (i == j)
                    {
                        arr[i, j] = rnd.Next(0, 10);
                    }
                    else 
                    {
                        arr[i, j] = rnd.Next(0, 10);
                    }
                    // Выводим весь массив
                    System.Console.Write($"{arr[i, j]} ");
                }
                System.Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        System.Console.WriteLine(arr[i, j]);
                    }
                }
            }
        }
    }
}
