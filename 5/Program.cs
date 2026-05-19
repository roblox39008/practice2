namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int randNum = rnd.Next(a, b + 1);
            Console.WriteLine($"Случайное число: {randNum}");
        }
    }
}
