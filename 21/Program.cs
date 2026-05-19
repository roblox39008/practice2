namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Внешний радиус R: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Внутренний радиус r: ");
            double r = double.Parse(Console.ReadLine());

            double S = Math.PI * (R * R - r * r);
            Console.WriteLine($"Площадь кольца: {S}");
        }
    }
}
