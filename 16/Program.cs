namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());

            double arithmetic = (x + y) / 2.0;
            double geometric = Math.Sqrt(x * y);

            Console.WriteLine($"Среднее арифметическое: {arithmetic}");
            Console.WriteLine($"Среднее геометрическое: {geometric}");
        }
    }
}
