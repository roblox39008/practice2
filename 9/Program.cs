namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 123.456789;
            double rounded = Math.Round(number, 2);
            Console.WriteLine($"Округлено до сотых: {rounded}");
        }
    }
}
