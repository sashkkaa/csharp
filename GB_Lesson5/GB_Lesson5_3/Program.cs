using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GB_Lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryFormatter formatter = new BinaryFormatter();

            Console.WriteLine("Введите числа от 0 до 255");
            Numbers numbers = new Numbers();
            numbers.num = Convert.ToInt16(Console.ReadLine());
            formatter.Serialize(new FileStream("binary.bin", FileMode.OpenOrCreate), numbers);
        }
    }

    [Serializable]
    public class Numbers
    {
        public int num { get; set; }
    }
}

