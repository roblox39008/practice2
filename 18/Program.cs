namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a (не равно 0): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());

            double x = -b / a;
            Console.WriteLine($"x = {x}");
        }
    }
}
