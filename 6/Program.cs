namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;

            c = (double)a + (double)b + c;
            Console.WriteLine($"Сумма в c: {c}");
        }
    }
}
