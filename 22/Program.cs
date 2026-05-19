namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Катет a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Катет b: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);
            double P = a + b + c;
            Console.WriteLine($"Периметр: {P}");
        }
    }
}
