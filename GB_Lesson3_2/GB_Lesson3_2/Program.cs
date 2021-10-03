using System;

namespace GB_Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Kolya", "Sashka", "Masha", "Petya", "Vasya" };
            string[] contacts = {"qwerty@qwe.ru", "+8 (999) 123 45 67", "ytrewq@ewq.ru", "+7 (874) 345 24 96", "qazwsx@edc.ru"};
            string[,] contactBook = new string[5, 2];

            Random rnd = new Random();

            for (int i = 0; i < contactBook.GetLength(0); i++)
            {
                for (int j = 0; j < contactBook.GetLength(1); j++)
                {
                    if (j == 0)
                        contactBook[i, j] = names[rnd.Next(0, names.Length)];
                    else
                        contactBook[i, j] = contacts[rnd.Next(0, contacts.Length)];

                    System.Console.Write($"{contactBook[i, j]} ");
                }
                System.Console.WriteLine();
            }

        }
    }
}
