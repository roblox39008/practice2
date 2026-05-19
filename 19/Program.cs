namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите e: ");
            double e = double.Parse(Console.ReadLine());

            double C = c - e;
            double discriminant = b * b - 4 * a * C;

            if (discriminant < 0)
                Console.WriteLine("Нет действительных корней");
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Один корень: x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Два корня: x1 = {x1}, x2 = {x2}");
            }
        }
    }
}
