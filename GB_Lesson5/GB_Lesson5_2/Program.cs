using System;
using System.IO;

namespace GB_Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "startup.txt";
            var curTime = Convert.ToString(DateTime.Now);
            File.AppendAllText(fileName, curTime);
            string checkTime = File.ReadAllText(fileName);
            Console.WriteLine($"Содержимое файла: {checkTime}");
            File.AppendAllText(fileName, Environment.NewLine);
        }
    }
}
