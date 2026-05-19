namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите массу (кг): ");
            double mass = double.Parse(Console.ReadLine());
            Console.Write("Введите объём (м³): ");
            double volume = double.Parse(Console.ReadLine());

            double density = mass / volume;
            Console.WriteLine($"Плотность: {density} кг/м³");
        }
    }
}
