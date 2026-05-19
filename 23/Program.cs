namespace _23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = double.Parse(Console.ReadLine());

            double absX = Math.Abs(x);
            double absY = Math.Abs(y);

            double arithmetic = (absX + absY) / 2.0;
            double geometric = Math.Sqrt(absX * absY);

            Console.WriteLine($"Среднее арифметическое модулей: {arithmetic}");
            Console.WriteLine($"Среднее геометрическое модулей: {geometric}");
        }
    }
}
