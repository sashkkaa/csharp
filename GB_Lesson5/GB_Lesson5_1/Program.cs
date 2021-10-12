using System;
using System.IO;

namespace GB_Lesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();
            string fileName = "Lesson1.txt";
            File.WriteAllText(fileName, text);
        }
    }
}
