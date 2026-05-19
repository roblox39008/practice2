using System;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат: {a * a}");
        }
    }
}
