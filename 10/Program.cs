namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double e = Math.E;
            double eRounded = Math.Round(e, 1);
            Console.WriteLine($"e до десятых: {eRounded}");
        }
    }
}
